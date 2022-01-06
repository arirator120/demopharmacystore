package com.dthd.quanlyquaythuoc.activity.client;

import androidx.annotation.NonNull;
import androidx.appcompat.app.ActionBarDrawerToggle;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.fragment.app.FragmentTransaction;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.employee.AdminHomeActivity;
import com.dthd.quanlyquaythuoc.fragment.AdminHomeFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerCompanyFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerEmployeeFragment;
import com.dthd.quanlyquaythuoc.model.user;
import com.google.android.material.navigation.NavigationView;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.Map;

public class ClientHomeActivity extends AppCompatActivity {
    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference mReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;
    Bundle bundle;

    Button signOut;
    DrawerLayout drawer;
    NavigationView navigationView;

//    Button btnLogout;
    user u;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_client_home);
        init();
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        if(mUser.getEmail().contains("@pharmacity.com")){
            mAuth.signOut();
            Intent intent = new Intent(ClientHomeActivity.this, ClientLoginActivity.class);
            startActivity(intent);
            finish();
        }

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar,
                R.string.navigation_drawer_open, R.string.navigation_drawer_close);

        FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
        fragmentTransaction.replace(R.id.fragment_container, new AdminHomeFragment());
        fragmentTransaction.commit();


        navigationView.setNavigationItemSelectedListener(new NavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                displayView(item);

//                DrawerLayout drawer = findViewById(R.id.drawer_layout);
                drawer.closeDrawer(GravityCompat.START);

                return true;
            }
        });

        //phải ở dưới navigation
        drawer.addDrawerListener(toggle);
        toggle.syncState();



        bundle = getIntent().getExtras();

        if(mUser != null)
            setUserFireBase(mUser);
    }

    private void setUserFireBase(FirebaseUser mUser){
        mReference = mDatabase.getReference("Users");
        String id = mUser.getUid();
        View headerView = navigationView.getHeaderView(0);
        TextView nameDisplay = headerView.findViewById(R.id.nameUser);
        String name ,phone, email;
        if(bundle != null){
            name = bundle.getString("object_name");
            phone = bundle.getString("object_phone");
            email = mUser.getEmail();

            //thêm vào object user

            //nếu đối tượng rỗng
            if(u ==null)
                u = new user(); //khởi tạo object để dùng trong app

            u.setName(name);
            u.setEmail(email);
            u.setId(id);
            u.setPhone(phone);
            u.setRole("Client");

        }

//        Log.d("user", u.toString());

        //bắt sự kiện ở mọi phần tử trong child(id)
        mReference.child(id).addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                //nếu nhánh id hk tồn tại
                if(!snapshot.exists()){
                    mReference.child(id).setValue(u);
                    if(bundle != null) {
                        nameDisplay.setText(bundle.getString("object_name")); //cẩn thận khi copy sẽ có thể sai
                    }
                }else{
//                    for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                    user uCurr = snapshot.getValue(user.class);
                    if(uCurr.getId().equals(id)){
                        nameDisplay.setText(uCurr.getName()); //dc

                    }
                    Log.d("messUser:", uCurr.getName());
//                    }
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {
                Log.d("TAG",error.getMessage());
            }
        });
    }

    @Override
    public void onBackPressed() {
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    private void init(){
        drawer = findViewById(R.id.drawer_layout);
        signOut = findViewById(R.id.signOut);
        navigationView = findViewById(R.id.nav_view);
    }

    private void signOut(){
        mAuth.signOut();
        Intent intent = new Intent(ClientHomeActivity.this, ClientLoginActivity.class);
        startActivity(intent);
        Toast.makeText(ClientHomeActivity.this, "Đăng xuất thành công!",Toast.LENGTH_SHORT).show();
    }

    public void displayView(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.nav_home:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new AdminHomeFragment()).commit();

                break;
            case R.id.nav_employee:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new ManagerEmployeeFragment()).commit();

                break;
            case R.id.nav_company:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new ManagerCompanyFragment()).commit();

                break;

            case R.id.signOut:
                finish();
                signOut();
                break;


        }

        item.setChecked(true);

    }



}