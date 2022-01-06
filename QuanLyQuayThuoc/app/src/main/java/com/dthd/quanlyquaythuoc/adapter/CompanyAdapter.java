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
import com.dthd.quanlyquaythuoc.model.company;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class CompanyAdapter extends RecyclerView.Adapter<CompanyAdapter.ViewHolder>  {
    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    private List<company> companyList;
    private Context mContext;

    public CompanyAdapter(List<company> companyList, Context mContext) {
        this.companyList = companyList;
        this.mContext = mContext;
    }

    @NonNull
    @Override
    public CompanyAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_company,parent,false);
        CompanyAdapter.ViewHolder holder = new CompanyAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull CompanyAdapter.ViewHolder holder, int position) {
        company c = companyList.get(position);
        if(c==null)
            return;


        holder.tvNameCompany.setText(c.getName());
        holder.tvPhone.setText(c.getPhone());
//        holder.ivPic.setImageResource(R.drawable.manufature);
        holder.layout_content.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDetail(c);
            }
        });

        holder.imgBtnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDelete(c);
            }
        });

    }

    private void onClickDetail(company c) {
        Intent i =new Intent(mContext, AddEditCompanyActivity.class);
        Bundle bundle = new Bundle();
        bundle.putSerializable("object_companies", c);
        i.putExtras(bundle);
        mContext.startActivity(i);
    }

    private void onClickDelete(company c) {
        new AlertDialog.Builder(mContext)
                .setTitle(mContext.getString(R.string.app_name))
                .setMessage("Bạn có chắc muốn xóa cái này?")
                .setPositiveButton("Xóa", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        _myRef = mDatabase.getReference("Companies");
                        _myRef.child(c.getId()).removeValue(); //xóa object trên fb
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
        if(companyList != null)
            return companyList.size(); //phải cái này để trả về số lượng item
        return 0;
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
//        ImageView ivPic;
        TextView tvNameCompany, tvPhone;
        ImageButton imgBtnDelete;
        LinearLayout layout_content;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
//            ivPic = itemView.findViewById(R.id.ivPic);
            layout_content = itemView.findViewById(R.id.layout_content);
            tvNameCompany = itemView.findViewById(R.id.tvNameCompany);
            tvPhone = itemView.findViewById(R.id.tvPhone);
            layout_item = itemView.findViewById(R.id.layout_item);
            imgBtnDelete = itemView.findViewById(R.id.imgBtnDelete);
        }
    }


}
