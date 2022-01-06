package com.dthd.quanlyquaythuoc.controller;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.content.DialogInterface;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.ViewMedicinesActivity;
import com.dthd.quanlyquaythuoc.fragment.AdminHomeFragment;
import com.dthd.quanlyquaythuoc.fragment.EmployeeHomeFragment;
import com.dthd.quanlyquaythuoc.model.cart;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class ViewEditActivity extends AppCompatActivity {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference dbReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;

    ImageView ivPic;
    TextView tvNameProduct, tvPrice,tvAmount, tvDate, tvDetails, tvCompany;
    ImageButton btnAdd;

    medicine m;
    BottomNavigationView bottomNavigationView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_edit);

        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        inIt();
        getData();

        Toolbar toolbar = findViewById(R.id.my_toolbar);
        setSupportActionBar(toolbar);

        getSupportActionBar().setTitle("Thông tin chi tiết");
        //set up back button
        toolbar.setNavigationIcon(getResources().getDrawable(R.drawable.ic_action_back));
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //What to do on back clicked
                Intent i = new Intent(ViewEditActivity.this, EmployeeHomeFragment.class);
                startService(i);
                finish();
            }
        });

        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                setDataAdd(m);
                finish();
            }
        });

    }


    public void inIt(){
        tvNameProduct = findViewById(R.id.tvNameProduct);
        tvPrice = findViewById(R.id.tvPrice);
        tvAmount = findViewById(R.id.tvAmount);
        tvDate =  findViewById(R.id.tvDate);
        tvCompany = findViewById(R.id.tvCompany);
        tvDetails = findViewById(R.id.tvDetails);
        bottomNavigationView = findViewById(R.id.bottom_navigation);
        ivPic = findViewById(R.id.ivPic);
        btnAdd = findViewById(R.id.btnAdd);
    }


    public void getData(){
        Bundle bundle = getIntent().getExtras();
        if(bundle==null) return;
        m = (medicine) bundle.get("object_medicines"); //nhận dữ liệu từ main gửi qua
        Glide.with(this)
                .load(String.valueOf(Uri.parse(m.getPic())))
                .into(ivPic); //ho tro doc uri
        tvNameProduct.setText(m.getName());
        String priceFormat = String.format("%,d", m.getPrice());
        String price = priceFormat.replace(",",".");
        tvPrice.setText(price);
        tvAmount.setText(m.getAmount() + "");
        tvDate.setText(m.getDate());
        tvDetails.setText(m.getDetails());

        tvCompany.setText(m.getCompany().getName());

    }

    public void setDataAdd(medicine m){
        if(m==null)
            return;

        dbReference = mDatabase.getReference("Carts"); //phai o trc getkey()

        cart c = new cart();
        String id = dbReference.push().getKey();
        c.setId(id);
        c.setAmount(1);
        c.setMedicine(m);
        c.setIdUser(mUser.getUid());



        c.setId(id);
        dbReference.child(c.getId()).setValue(c); //tạo value cho nhánh trên fb
        Toast.makeText(ViewEditActivity.this,"Đã thêm sản phẩm vào giỏ hàng",Toast.LENGTH_SHORT).show();

    }


}