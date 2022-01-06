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
import android.widget.Button;
import android.widget.ImageButton;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.employee.AdminHomeActivity;
import com.dthd.quanlyquaythuoc.adapter.CompanyAdapter;
import com.dthd.quanlyquaythuoc.controller.AddEditCompanyActivity;
import com.dthd.quanlyquaythuoc.model.company;
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
public class ManagerCompanyFragment extends Fragment {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;
    RecyclerView rvCompany;
    //    Button btnAdd;
    List<company> listCompany;
    List<String> mKeys = new ArrayList<>(); //lưu trữ keys trên fb
    CompanyAdapter adapter;
    ImageButton imgBtnAdd;

    public ManagerCompanyFragment() {
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
        View v = inflater.inflate(R.layout.fragment_manager_company, container, false);
        ((AdminHomeActivity)getActivity()).getSupportActionBar().setTitle("Quản lý nhà cung cấp");

        rvCompany = v.findViewById(R.id.rvCompany);
        imgBtnAdd = v.findViewById(R.id.imgBtnAdd);
        getData();
        //Log.d("messages",listInstruments.toString() + "");
        rvCompany.setLayoutManager(new LinearLayoutManager(v.getContext()));
        rvCompany.setHasFixedSize(true);
        adapter = new CompanyAdapter(listCompany,v.getContext());
        rvCompany.setAdapter(adapter);

        imgBtnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(getContext(), AddEditCompanyActivity.class);
                startActivity(i);
            }
        });


        return v;
    }

    public void getData() {
        listCompany = new ArrayList<>();
        _myRef = mDatabase.getReference("Companies");
        //bắt sự kiện khi có bất kỳ nhánh con nào được thêm xóa sửa, thì sẽ cập nhật lại data
        _myRef.addChildEventListener(new ChildEventListener() {
            @Override
            public void onChildAdded(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                company c = snapshot.getValue(company.class);
                if (c !=null){
                    listCompany.add(c);
                    String key = snapshot.getKey();
                    mKeys.add(key);
                    adapter.notifyDataSetChanged();
                }
                //Log.d("m",c+ "");
            }

            @Override
            public void onChildChanged(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                company c = snapshot.getValue(company.class);
                if(c == null || listCompany == null || listCompany.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey()); //tìm vị trí của key trong fb tương ứng key trong listPerson
                listCompany.set(index, c); //tại vị trí đó, cập nhật gtri p
                adapter.notifyDataSetChanged();
            }

            @Override
            public void onChildRemoved(@NonNull DataSnapshot snapshot) {
                company c = snapshot.getValue(company.class);
                if(c == null || listCompany == null || listCompany.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey());
                if(index != -1){
                    listCompany.remove(index);
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