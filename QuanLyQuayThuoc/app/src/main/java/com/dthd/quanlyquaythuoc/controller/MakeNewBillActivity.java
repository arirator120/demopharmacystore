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
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.TextView;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.adapter.BillCartAdapter;
import com.dthd.quanlyquaythuoc.adapter.CartAdapter;
import com.dthd.quanlyquaythuoc.fragment.BillHistoryFragment;
import com.dthd.quanlyquaythuoc.fragment.EmployeeHomeFragment;
import com.dthd.quanlyquaythuoc.model.bill;
import com.dthd.quanlyquaythuoc.model.cart;
import com.dthd.quanlyquaythuoc.model.user;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.ChildEventListener;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Map;

public class MakeNewBillActivity extends AppCompatActivity {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference mReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;
    RecyclerView rvBill;
    List<cart> listCarts;
    List<String> mKeys = new ArrayList<>(); //lưu trữ keys trên fb
    BillCartAdapter adapter;
    Toolbar toolbar;
    EditText etName, etNameClient, etAddress, etPhone;
    Button btnConfirm;
    TextView tvSum;

    bill b;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_make_new_bill);
        init();

        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        //Set toolbar
        setSupportActionBar(toolbar);
        toolbar.setTitle("");

        getSupportActionBar().setTitle("Lập hóa đơn");
        //set up back button
        toolbar.setNavigationIcon(getResources().getDrawable(R.drawable.ic_action_back));
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //What to do on back clicked
                Intent i = new Intent(MakeNewBillActivity.this, AmountMedicinesActivity.class);
                startActivity(i);
                finish();
            }
        });

        getEmployee();
        getData();

        rvBill.setLayoutManager(new LinearLayoutManager(this));
        rvBill.setHasFixedSize(true);
        adapter = new BillCartAdapter(listCarts,this, tvSum);
        rvBill.setAdapter(adapter);

        btnConfirm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(errorMsg() == ""){
                    setData(b);
                    clearCart();
                    Intent i = new Intent(MakeNewBillActivity.this, BillHistoryFragment.class);
                    startService(i);
                    finish();
                }else{
                    Toast.makeText(MakeNewBillActivity.this, errorMsg(), Toast.LENGTH_LONG).show();
                }
            }
        });


    }

    private void init(){
        toolbar = findViewById(R.id.my_toolbar);
        rvBill = findViewById(R.id.rvBill);
        etName = findViewById(R.id.etName);
        etNameClient = findViewById(R.id.etNameClient);
        etAddress = findViewById(R.id.etAddress);
        etPhone = findViewById(R.id.etPhone);
        btnConfirm = findViewById(R.id.btnConfirm);
        tvSum = findViewById(R.id.tvSum);
    }

    public void getEmployee(){
        mReference = mDatabase.getReference("Users");
        mReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                if (snapshot.exists()) {
                    for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                        user u= dataSnapshot.getValue(user.class);
                        if(u.getId().equals(mUser.getUid())){
                            etName.setText(u.getName()); //dc
                        }
                    }
                }
            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });
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

    private String errorMsg(){
        if(etNameClient.getText().toString().isEmpty())
            return "Vui lòng nhập tên khách hàng!";
        if(etPhone.getText().toString().isEmpty())
            return "Vui lòng nhập số điện thoại";
        if(etAddress.getText().toString().isEmpty())
            return "Vui lòng nhập địa chỉ!";
        return "";
    }

    private void setData(bill b){
        if (b== null)
            b = new bill();

        String id = mReference.push().getKey();
        b.setId(id);
        b.setIdEmployee(mUser.getUid());
        b.setNameEmployee(etName.getText().toString());
        b.setNameClient(etNameClient.getText().toString());
        b.setPhone(etPhone.getText().toString());
        b.setAddress(etAddress.getText().toString());
        b.setLstCart(listCarts);
        b.setDate(getDateTime());
        b.setSum(adapter.sumList(listCarts));
//        b.setSum(Double.parseDouble(tvSum.getText().toString()));

        mReference = mDatabase.getReference("BillsHistory");

        mReference.child(b.getId()).setValue(b); //tạo value cho nhánh trên fb
        Toast.makeText(MakeNewBillActivity.this,"Lập đơn hàng thành công!!",Toast.LENGTH_SHORT).show();

    }

    private String getDateTime() {
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd/MM/yy");
        Date date = new Date();
        return dateFormat.format(date);
    }

    //xoa thanh cong
    public void clearCart(){
        DatabaseReference dbReference = mDatabase.getReference("Carts"); //phải tạo lại dbReference
        dbReference.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                if (snapshot.exists()) {
                    for (DataSnapshot dataSnapshot : snapshot.getChildren()) {
                        cart c = dataSnapshot.getValue(cart.class);
                            if(c.getIdUser().equals(mUser.getUid())){
                                dbReference.child(c.getId()).removeValue(); //xóa object trên fb
                            }
                    } }
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