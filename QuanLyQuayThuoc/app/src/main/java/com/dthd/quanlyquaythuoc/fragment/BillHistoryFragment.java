package com.dthd.quanlyquaythuoc.fragment;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.employee.AdminHomeActivity;
import com.dthd.quanlyquaythuoc.activity.employee.EmployeeHomeActivity;
import com.dthd.quanlyquaythuoc.adapter.BillHistoryAdapter;
import com.dthd.quanlyquaythuoc.adapter.EmployeeAdapter;
import com.dthd.quanlyquaythuoc.model.bill;
import com.dthd.quanlyquaythuoc.model.user;
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
public class BillHistoryFragment extends Fragment {


    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    RecyclerView rvHistoryBill;
    List<bill> listHistory;
    List<String> mKeys = new ArrayList<>(); //lưu trữ keys trên fb
    BillHistoryAdapter adapter;

    public BillHistoryFragment() {
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
        View v = inflater.inflate(R.layout.fragment_bill_history, container, false);
        ((EmployeeHomeActivity)getActivity()).getSupportActionBar().setTitle("Lịch sử lập đơn");

        rvHistoryBill = v.findViewById(R.id.rvHistoryBill);
        getData();

        LinearLayoutManager mLayoutManager = new LinearLayoutManager(v.getContext());
        mLayoutManager.setReverseLayout(true);
        mLayoutManager.setStackFromEnd(true);

        rvHistoryBill.setLayoutManager(mLayoutManager);
        rvHistoryBill.setHasFixedSize(true);
        adapter = new BillHistoryAdapter(listHistory,v.getContext());
        rvHistoryBill.setAdapter(adapter);

        return v;
    }

    public void getData() {
        listHistory = new ArrayList<>();
        _myRef = mDatabase.getReference("BillsHistory");
        //bắt sự kiện khi có bất kỳ nhánh con nào được thêm xóa sửa, thì sẽ cập nhật lại data
        _myRef.addChildEventListener(new ChildEventListener() {
            @Override
            public void onChildAdded(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                bill b = snapshot.getValue(bill.class);
                if (b !=null){
                    listHistory.add(b);
                    String key = snapshot.getKey();
                    mKeys.add(key);
                    adapter.notifyDataSetChanged();
                }
            }

            @Override
            public void onChildChanged(@NonNull DataSnapshot snapshot, @Nullable String previousChildName) {
                bill b = snapshot.getValue(bill.class);
                if(b == null || listHistory == null || listHistory.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey()); //tìm vị trí của key trong fb tương ứng key trong listPerson
                listHistory.set(index, b); //tại vị trí đó, cập nhật gtri p
                adapter.notifyDataSetChanged();
            }

            @Override
            public void onChildRemoved(@NonNull DataSnapshot snapshot) {
                bill b = snapshot.getValue(bill.class);
                if(b == null || listHistory == null || listHistory.isEmpty())
                    return;
                int index = mKeys.indexOf(snapshot.getKey());
                if(index != -1){
                    listHistory.remove(index);
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