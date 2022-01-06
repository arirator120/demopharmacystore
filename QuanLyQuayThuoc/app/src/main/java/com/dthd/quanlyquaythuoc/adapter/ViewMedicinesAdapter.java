package com.dthd.quanlyquaythuoc.adapter;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.ViewMedicinesActivity;
import com.dthd.quanlyquaythuoc.controller.ViewEditActivity;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;

import java.util.List;

public class ViewMedicinesAdapter extends RecyclerView.Adapter<ViewMedicinesAdapter.ViewHolder> {
    private List<medicine> medicineList;
    private Context mContext;


    FirebaseAuth mAuth;
    FirebaseUser mUser;

    public ViewMedicinesAdapter(List<medicine> medicineList, Context mContext) {
        this.medicineList = medicineList;
        this.mContext = mContext;
    }


    @NonNull
    @Override
    public ViewMedicinesAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_medicine,parent,false);
        ViewMedicinesAdapter.ViewHolder holder = new ViewMedicinesAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull ViewMedicinesAdapter.ViewHolder holder, int position) {
        medicine m = medicineList.get(position);
        if(m==null)
            return;

        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();
        holder.tvNameProduct.setText(m.getName());
        String priceFormat = String.format("%,d",m.getPrice());
        String price = priceFormat.replace(",","."); //thay , thành .
        holder.tvPrice.setText(price);
        Glide.with(mContext)
                .load(String.valueOf(Uri.parse(m.getPic())))
                .into(holder.ivPic); //ho tro doc uri

        holder.layout_item.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDetail(m);
            }
        });

    }

    private void onClickDetail(medicine m) {
        Intent i;
        if(mUser.getEmail().contains("@pharmacity.com") && !mUser.getEmail().equals("admin@pharmacity.com")){
            i =new Intent(mContext, ViewEditActivity.class);
        }else{
            i =new Intent(mContext, ViewMedicinesActivity.class);
        }
        Bundle bundle = new Bundle();
        bundle.putSerializable("object_medicines", m);
        i.putExtras(bundle);
        mContext.startActivity(i);
    }



    public void release(){
        mContext=null;
    }

    @Override
    public int getItemCount() {
        if(medicineList != null)
            return medicineList.size(); //phải cái này để trả về số lượng item
        return 0;
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
        ImageView ivPic;
        TextView tvNameProduct, tvPrice;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            ivPic = itemView.findViewById(R.id.ivPic);
            tvNameProduct = itemView.findViewById(R.id.tvNameProduct);
            tvPrice = itemView.findViewById(R.id.tvPrice);
            layout_item = itemView.findViewById(R.id.layout_item);
        }
    }
}
