package com.dthd.quanlyquaythuoc.controller;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;

import com.dthd.quanlyquaythuoc.fragment.ManagerCompanyFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerEmployeeFragment;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.user;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class AddEditEmployeeActivity extends AppCompatActivity {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference dbReference;

    EditText etName, etPhone;
    RadioGroup groupSex;
    RadioButton radOn, radOff;

    Bundle bundle;
    user u;

    boolean flag = false;

    BottomNavigationView bottomNavigationView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_edit_employee);


        init();
        bundle =  getIntent().getExtras();

        //Set toolbar
        Toolbar toolbar = findViewById(R.id.my_toolbar);
        setSupportActionBar(toolbar);
        toolbar.setTitle("");

        getSupportActionBar().setTitle("");
        toolbar.setNavigationIcon(getResources().getDrawable(R.drawable.ic_action_back));
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //What to do on back clicked
                Intent i = new Intent(AddEditEmployeeActivity.this, ManagerEmployeeFragment.class);
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
                        setData(u);

                    }else{
                        Toast.makeText(AddEditEmployeeActivity.this, errorMsg(), Toast.LENGTH_LONG).show();
                        return false;
                    }

                }
                finish();
                return false;

            }

        });
    }

    private void init(){
        etName = findViewById(R.id.etName);
        etPhone = findViewById(R.id.etPhone);
        groupSex = findViewById(R.id.groupSex);
        radOn =  findViewById(R.id.radOn);
        radOff = findViewById(R.id.radOff);
        bottomNavigationView = findViewById(R.id.bottom_navigation);
    }

    public void getData(){
        //nếu mà kh có dl lập tức skip phần còn lại bên dưới
        if(bundle == null){
            return;
        }
        flag = true; //edit
        u = (user) bundle.get("object_employees"); //u nay phai la global

        etName.setText(u.getName());
        etPhone.setText(u.getPhone());

        if(u.isSex() == true)
            groupSex.check(radOn.getId());
        else
            groupSex.check(radOff.getId());
    }

    public void setData(user u){
        //nếu đối tượng rỗng
        if(u==null)
            u = new user(); //khởi tạo object

        u.setName(etName.getText().toString());
        u.setPhone(etPhone.getText().toString());
        if(radOn.isChecked()) u.setSex(true);
        else u.setSex(false);
        u.setRole("Pharmacists");

        dbReference = mDatabase.getReference("Users");

        if(flag == false){
            //add
            String id = dbReference.push().getKey();
            u.setId(id);
            dbReference.child(u.getId()).setValue(u); //tạo value cho nhánh trên fb
            Toast.makeText(AddEditEmployeeActivity.this,"Thêm dữ liệu hoàn tất!!",Toast.LENGTH_SHORT).show();
        }
        else{
            //edit
            dbReference.child(u.getId()).setValue(u);
            Intent i = new Intent(AddEditEmployeeActivity.this, ManagerEmployeeFragment.class);
            startService(i);
            //finish();
            Toast.makeText(AddEditEmployeeActivity.this,"Cập nhật hoàn tất!!",Toast.LENGTH_SHORT).show();
        }


    }

    //ktra có lỗi hay hk
    private String errorMsg(){
        if(etName.getText().toString().isEmpty())
            return "Vui lòng nhập tên nhân viên!";
        if(etPhone.getText().toString().isEmpty())
            return "Vui lòng nhập số điện thoại";
        return "";
    }
}