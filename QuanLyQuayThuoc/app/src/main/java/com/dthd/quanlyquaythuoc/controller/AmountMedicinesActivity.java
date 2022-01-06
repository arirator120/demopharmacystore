package com.dthd.quanlyquaythuoc.controller;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.adapter.CartAdapter;
import com.dthd.quanlyquaythuoc.fragment.EmployeeHomeFragment;
import com.dthd.quanlyquaythuoc.model.cart;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.ChildEventListener;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.ArrayList;
import java.util.List;

public class AmountMedicinesActivity extends AppCompatActivity {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference mReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;
    RecyclerView rvCart;
    List<cart> listCarts;
    List<String> mKeys = new ArrayList<>(); //lưu trữ keys trên fb
    CartAdapter adapter;
    Button btnMake;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_amount_medicines);

        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        //Set toolbar
        Toolbar toolbar = findViewById(R.id.my_toolbar);
        rvCart = findViewById(R.id.rvCart);
        btnMake = findViewById(R.id.btnMake);

        setSupportActionBar(toolbar);
        toolbar.setTitle("");

        getSupportActionBar().setTitle("Giỏ hàng");
        //set up back button
        toolbar.setNavigationIcon(getResources().getDrawable(R.drawable.ic_action_back));
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //What to do on back clicked
                Intent i = new Intent(AmountMedicinesActivity.this, EmployeeHomeFragment.class);
                startService(i);
                finish();
            }
        });

        getData();
        rvCart.setLayoutManager(new LinearLayoutManager(this));
        rvCart.setHasFixedSize(true);
        adapter = new CartAdapter(listCarts,this);
        rvCart.setAdapter(adapter);

    }

    public void getData() {
        listCarts = new ArrayList<>();
        mReference = mDatabase.getReference("Carts");
        //bắt sự kiện khi có bất kỳ nhánh con nào được thêm xóa sửa, thì sẽ cập nhật lại data
        mReference.addChildEventListener(new ChildEventListener() {
            @Override
            public void onChildAdded(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                cart c = snapshot.getValue(cart.class);
                if (c !=null && mUser.getUid().equals(c.getIdUser())){
                    listCarts.add(c); //khi co thi moi cho qua acti tiep
                    String key = snapshot.getKey();
                    mKeys.add(key);
                    adapter.notifyDataSetChanged();
                }
                //de duoc o day
                btnMake.setOnClickListener(new View.OnClickListener() {
                    @Override
                    public void onClick(View view) {
                        if (listCarts.isEmpty()){
                            Toast.makeText(AmountMedicinesActivity.this, "Vui lòng thêm ít nhất 1 sản phẩm!", Toast.LENGTH_LONG).show();
                        }
                        else{
                            Intent i = new Intent(AmountMedicinesActivity.this,MakeNewBillActivity.class);
                            startActivity(i);
                            finish();
                        }
                    }
                });
            }

            @Override
            public void onChildChanged(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                cart c = snapshot.getValue(cart.class);
                if(c == null || listCarts == null || listCarts.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey()); //tìm vị trí của key trong fb tương ứng key trong listPerson
                listCarts.set(index, c); //tại vị trí đó, cập nhật gtri p
                adapter.notifyDataSetChanged();
            }

            @Override
            public void onChildRemoved(@NonNull DataSnapshot snapshot) {
                cart c = snapshot.getValue(cart.class);
                if(c == null || listCarts == null || listCarts.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey());
                if(index != -1){
                    listCarts.remove(index);
                    mKeys.remove(index);
                }
                adapter.notifyDataSetChanged();
            }

            @Override
            public void onChildMoved(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {

            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });
    }


    @Override
    public void onDestroy() {
        super.onDestroy();
        if(adapter!=null)
            adapter.release();
    }
}