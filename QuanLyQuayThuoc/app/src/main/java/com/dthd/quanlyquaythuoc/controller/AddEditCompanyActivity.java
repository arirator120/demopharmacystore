package com.dthd.quanlyquaythuoc.controller;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.fragment.ManagerCompanyFragment;
import com.dthd.quanlyquaythuoc.model.company;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class AddEditCompanyActivity extends AppCompatActivity {
    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference dbReference;

    EditText etNameCompany, etPhone, etAddress;

    Bundle bundle;
    company c;

    boolean flag = false;

    BottomNavigationView bottomNavigationView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_edit_company);

        init();
        bundle =  getIntent().getExtras();

        //Set toolbar
        Toolbar toolbar = findViewById(R.id.my_toolbar);
        setSupportActionBar(toolbar);
        toolbar.setTitle("");

        getSupportActionBar().setTitle("");
        //set up back button
        toolbar.setNavigationIcon(getResources().getDrawable(R.drawable.ic_action_back));
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //What to do on back clicked
                Intent i = new Intent(AddEditCompanyActivity.this, ManagerCompanyFragment.class);
                startService(i);
                finish();
            }
        });

        getData();


        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                int id = item.getItemId();
                if(id == R.id.menu_bottom_save){
                    if(errorMsg() == ""){
                        setData(c);

                    }else{
                        Toast.makeText(AddEditCompanyActivity.this, errorMsg(), Toast.LENGTH_LONG).show();
                        return false;
                    }

                }
                finish();
                return false;

            }

        });

    }


    private void init(){
        etNameCompany = findViewById(R.id.etNameCompany);
        etPhone = findViewById(R.id.etPhone);
        etAddress = findViewById(R.id.etAddress);
        bottomNavigationView = findViewById(R.id.bottom_navigation);
    }

    public void getData(){
        //nếu mà kh có dl lập tức skip phần còn lại bên dưới
        if(bundle == null){
            return;
        }
        flag = true; //edit
        c = (company) bundle.get("object_companies");

        etNameCompany.setText(c.getName());
        etPhone.setText(c.getPhone());
        etAddress.setText(c.getAddress());
    }

    public void setData(company c){
        //nếu đối tượng rỗng
        if(c==null)
            c = new company(); //khởi tạo object

        c.setName(etNameCompany.getText().toString());
        c.setPhone(etPhone.getText().toString());
        c.setAddress(etAddress.getText().toString());

        dbReference = mDatabase.getReference("Companies");

        if(flag == false){
            //add
            String id = dbReference.push().getKey();
            c.setId(id);
            dbReference.child(c.getId()).setValue(c); //tạo value cho nhánh trên fb
            Toast.makeText(AddEditCompanyActivity.this,"Thêm dữ liệu hoàn tất!!",Toast.LENGTH_SHORT).show();
        }
        else{
            //edit
            dbReference.child(c.getId()).setValue(c); //thay đổi giá trị theo getdata thông qua biến ins
            Intent i = new Intent(AddEditCompanyActivity.this, ManagerCompanyFragment.class);
            startService(i);
            //finish();
            Toast.makeText(AddEditCompanyActivity.this,"Cập nhật hoàn tất!!",Toast.LENGTH_SHORT).show();
        }


    }

    //ktra có lỗi hay hk
    private String errorMsg(){
        if(etNameCompany.getText().toString().isEmpty())
            return "Vui lòng nhập tên nhà cung cấp!";
        if(etPhone.getText().toString().isEmpty())
            return "Vui lòng nhập số điện thoại";
        if(etAddress.getText().toString().isEmpty())
            return "Vui lòng nhập địa chỉ!";
        return "";
    }

}