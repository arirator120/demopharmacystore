package com.dthd.quanlyquaythuoc.activity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.adapter.ViewMedicinesAdapter;
import com.dthd.quanlyquaythuoc.fragment.AdminHomeFragment;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class ViewMedicinesActivity extends AppCompatActivity {
    ImageView ivPic;
    TextView tvNameProduct, tvPrice, tvDate, tvDetails, tvCompany;

    medicine m;
    BottomNavigationView bottomNavigationView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_view_medicines);

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
                Intent i = new Intent(ViewMedicinesActivity.this, AdminHomeFragment.class);
                startService(i);
                finish();
            }
        });
    }

    public void inIt(){
        tvNameProduct =  findViewById(R.id.tvNameProduct);
        tvPrice =  findViewById(R.id.tvPrice);
        tvDate =  findViewById(R.id.tvDate);
        tvCompany =  findViewById(R.id.tvCompany);
        tvDetails =  findViewById(R.id.tvDetails);
        ivPic = findViewById(R.id.ivPic);
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
        tvDate.setText(m.getDate());
        tvDetails.setText(m.getDetails());

        tvCompany.setText(m.getCompany().getName());

    }
}