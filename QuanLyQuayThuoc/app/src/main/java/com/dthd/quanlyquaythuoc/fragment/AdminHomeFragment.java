package com.dthd.quanlyquaythuoc.fragment;

import android.content.Intent;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.client.ClientHomeActivity;
import com.dthd.quanlyquaythuoc.activity.client.ClientLoginActivity;
import com.dthd.quanlyquaythuoc.activity.employee.AdminHomeActivity;
import com.dthd.quanlyquaythuoc.activity.employee.EmployeeHomeActivity;
import com.dthd.quanlyquaythuoc.adapter.MedicineAdapter;
import com.dthd.quanlyquaythuoc.adapter.ViewMedicinesAdapter;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.ChildEventListener;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.ArrayList;
import java.util.List;

/**
 * A simple {@link Fragment} subclass.
 * create an instance of this fragment.
 */
public class AdminHomeFragment extends Fragment {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference mReference;
    FirebaseAuth mAuth;
    FirebaseUser mUser;
    RecyclerView rvMedicine;
    List<medicine> listMedicines;
    List<String> mKeys = new ArrayList<>(); //lưu trữ keys trên fb
    ViewMedicinesAdapter adapter;


    public AdminHomeFragment() {
        // Required empty public constructor
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View v = inflater.inflate(R.layout.fragment_admin_home, container, false);
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();


        if(mUser.getEmail().contains("@pharmacity.com")){
            ((AdminHomeActivity)getActivity()).getSupportActionBar().setTitle("Trang chủ");
        }else{
            ((ClientHomeActivity)getActivity()).getSupportActionBar().setTitle("Trang chủ");
        }


        rvMedicine = v.findViewById(R.id.rvMedicine);
        getData();
        //Log.d("messages",listInstruments.toString() + "");
        rvMedicine.setLayoutManager(new LinearLayoutManager(getContext()));
        rvMedicine.setHasFixedSize(true);
        adapter = new ViewMedicinesAdapter(listMedicines,getContext());
        rvMedicine.setAdapter(adapter);

        return v;
    }


    public void getData() {
        listMedicines = new ArrayList<>();
        mReference = mDatabase.getReference("Medicines");
        //bắt sự kiện khi có bất kỳ nhánh con nào được thêm xóa sửa, thì sẽ cập nhật lại data
        mReference.addChildEventListener(new ChildEventListener() {
            @Override
            public void onChildAdded(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                medicine m = snapshot.getValue(medicine.class); // p = đối tượng từ fb trả về
                if (m !=null){
                    listMedicines.add(m);
                    String key = snapshot.getKey();
                    mKeys.add(key);
                    adapter.notifyDataSetChanged();
                }
                //Log.d("m",ins+ "");
            }

            @Override
            public void onChildChanged(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                medicine m = snapshot.getValue(medicine.class);
                if(m == null || listMedicines == null || listMedicines.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey()); //tìm vị trí của key trong fb tương ứng key trong listPerson
                listMedicines.set(index, m); //tại vị trí đó, cập nhật gtri p
                adapter.notifyDataSetChanged();
            }

            @Override
            public void onChildRemoved(@NonNull DataSnapshot snapshot) {
                medicine m = snapshot.getValue(medicine.class);
                if(m == null || listMedicines == null || listMedicines.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey());
                if(index != -1){
                    listMedicines.remove(index);
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