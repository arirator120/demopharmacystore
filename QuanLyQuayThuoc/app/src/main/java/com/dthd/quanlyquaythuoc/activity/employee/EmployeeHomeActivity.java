package com.dthd.quanlyquaythuoc.activity.employee;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.ActionBarDrawerToggle;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.core.view.GravityCompat;
import androidx.drawerlayout.widget.DrawerLayout;
import androidx.fragment.app.FragmentTransaction;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.client.ClientLoginActivity;
import com.dthd.quanlyquaythuoc.adapter.MedicineAdapter;
import com.dthd.quanlyquaythuoc.fragment.AdminHomeFragment;
import com.dthd.quanlyquaythuoc.fragment.BillHistoryFragment;
import com.dthd.quanlyquaythuoc.fragment.EmployeeHomeFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerCompanyFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerEmployeeFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerMedicinesFragment;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.dthd.quanlyquaythuoc.model.user;
import com.dthd.quanlyquaythuoc.controller.AddMedicineActivity;
import com.google.android.material.navigation.NavigationView;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.ChildEventListener;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.List;

public class EmployeeHomeActivity extends AppCompatActivity {
    DrawerLayout drawer;
    NavigationView navigationView;

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference dbReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;

    user u;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_employee_home);
        init();
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        getSupportActionBar().setTitle("Trang chủ");
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar,
                R.string.navigation_drawer_open, R.string.navigation_drawer_close);

        FragmentTransaction fragmentTransaction = getSupportFragmentManager().beginTransaction();
        fragmentTransaction.replace(R.id.fragment_container, new EmployeeHomeFragment());
        fragmentTransaction.commit();


        navigationView.setNavigationItemSelectedListener(new NavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                displayView(item);
                drawer.closeDrawer(GravityCompat.START);

                return true;
            }
        });

        //phải ở dưới navigation
        drawer.addDrawerListener(toggle);
        toggle.syncState();


        View headerView = navigationView.getHeaderView(0);
        TextView name = headerView.findViewById(R.id.nameUser);


        dbReference = mDatabase.getReference("Users");
        dbReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                if (snapshot.exists()) {
                    for (DataSnapshot dataSnapshot : snapshot.getChildren()) {

                        user u= dataSnapshot.getValue(user.class);
                        if(u.getId().equals(mUser.getUid())){
                            name.setText(u.getName()); //dc
                        }
                    }
                }


            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });


    }

    private void init(){
        drawer = findViewById(R.id.drawer_layout);
        navigationView = findViewById(R.id.nav_view);
    }

    @Override
    public void onBackPressed() {
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    private void signOut(){
        mAuth.signOut();
        Intent intent = new Intent(EmployeeHomeActivity.this, EmployeeLoginActivity.class);
        startActivity(intent);
        Toast.makeText(EmployeeHomeActivity.this, "Signed out successfully",Toast.LENGTH_SHORT).show();
    }

    public void displayView(MenuItem item) {
        switch (item.getItemId()) {
            case R.id.nav_home:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new EmployeeHomeFragment()).commit();

                break;
            case R.id.nav_medicines:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new ManagerMedicinesFragment()).commit();

                break;

            case R.id.nav_history:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new BillHistoryFragment()).commit();

                break;

            case R.id.signOut:
                finish();
                signOut();
                break;


        }

        item.setChecked(true);

    }


}