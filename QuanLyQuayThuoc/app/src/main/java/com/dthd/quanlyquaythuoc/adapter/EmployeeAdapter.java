package com.dthd.quanlyquaythuoc.adapter;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.controller.AddEditCompanyActivity;
import com.dthd.quanlyquaythuoc.controller.AddEditEmployeeActivity;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.user;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class EmployeeAdapter extends RecyclerView.Adapter<EmployeeAdapter.ViewHolder>  {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    private List<user> employeeList;
    private Context mContext;

    public EmployeeAdapter(List<user> employeeList, Context mContext) {
        this.employeeList = employeeList;
        this.mContext = mContext;
    }

    @NonNull
    @Override
    public EmployeeAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_company,parent,false);
        EmployeeAdapter.ViewHolder holder = new EmployeeAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull EmployeeAdapter.ViewHolder holder, int position) {
        user u = employeeList.get(position);
        if(u==null)
            return;


        holder.tvNameCompany.setText(u.getName());
        holder.tvPhone.setText(u.getPhone());
        if(u.isSex()) holder.ivPic.setImageResource(R.drawable.male);
        else holder.ivPic.setImageResource(R.drawable.female);

        holder.layout_content.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDetail(u);
            }
        });

        holder.imgBtnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDelete(u);
            }
        });

    }

    private void onClickDetail(user u) {
        Intent i =new Intent(mContext, AddEditEmployeeActivity.class);
        Bundle bundle = new Bundle();
        bundle.putSerializable("object_employees", u);
        i.putExtras(bundle);
        mContext.startActivity(i);
    }

    private void onClickDelete(user u) {
        new AlertDialog.Builder(mContext)
                .setTitle(mContext.getString(R.string.app_name))
                .setMessage("Bạn có chắc muốn xóa nhân viên này?")
                .setPositiveButton("Xóa", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        _myRef = mDatabase.getReference("Users");
                        _myRef.child(u.getId()).removeValue(); //xóa object trên fb
                        Toast.makeText(mContext, "Xóa thành công!!", Toast.LENGTH_LONG).show();
                        dialogInterface.dismiss();
                    }
                })
                .setNegativeButton("Dừng", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        dialogInterface.dismiss();
                    }
                })
                .show();
    }




    public void release(){
        mContext=null;
    }

    @Override
    public int getItemCount() {
        if(employeeList != null)
            return employeeList.size(); //phải cái này để trả về số lượng item
        return 0;
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
        ImageView ivPic;
        TextView tvNameCompany, tvPhone;
        ImageButton imgBtnDelete;
        LinearLayout layout_content;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            ivPic = itemView.findViewById(R.id.ivPic);
            layout_content = itemView.findViewById(R.id.layout_content);
            tvNameCompany = itemView.findViewById(R.id.tvNameCompany);
            tvPhone = itemView.findViewById(R.id.tvPhone);
            layout_item = itemView.findViewById(R.id.layout_item);
            imgBtnDelete = itemView.findViewById(R.id.imgBtnDelete);
        }
    }
}
