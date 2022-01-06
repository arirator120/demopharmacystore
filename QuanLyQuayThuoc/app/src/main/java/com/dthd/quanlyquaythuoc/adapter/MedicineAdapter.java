package com.dthd.quanlyquaythuoc.adapter;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.util.Log;
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

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.controller.AddMedicineActivity;
import com.dthd.quanlyquaythuoc.controller.ViewEditActivity;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.dthd.quanlyquaythuoc.model.user;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class MedicineAdapter extends RecyclerView.Adapter<MedicineAdapter.ViewHolder> {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    FirebaseAuth mAuth;
    FirebaseUser mUser;

    private List<medicine> medicineList;
    private Context mContext;

    public MedicineAdapter(List<medicine> medicineList, Context mContext) {
        this.medicineList = medicineList;
        this.mContext = mContext;
    }


    @NonNull
    @Override
    public MedicineAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_medicine_manage,parent,false);
        ViewHolder holder = new ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder holder, int position) {
        medicine m = medicineList.get(position);
        if(m==null)
            return;

        holder.tvNameProduct.setText(m.getName());
        String priceFormat = String.format("%,d",m.getPrice());
        String price = priceFormat.replace(",","."); //thay , thành .
        holder.tvPrice.setText(price);
        Glide.with(mContext)
                .load(String.valueOf(Uri.parse(m.getPic())))
                .into(holder.ivPic); //ho tro doc uri

        holder.layout_content.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDetail(m);
            }
        });

        holder.imgBtnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDelete(m);
            }
        });

    }

    private void onClickDetail(medicine m) {
        Intent i =new Intent(mContext, AddMedicineActivity.class);
        Bundle bundle = new Bundle();
        bundle.putSerializable("object_medicines", m);
        i.putExtras(bundle);
        mContext.startActivity(i);
    }

    private void onClickDelete(medicine m) {
        new AlertDialog.Builder(mContext)
                .setTitle(mContext.getString(R.string.app_name))
                .setMessage("Bạn có chắc muốn xóa sản phẩm này?")
                .setPositiveButton("Xóa", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        _myRef = mDatabase.getReference("Medicines");
                        _myRef.child(m.getId()).removeValue(); //xóa object trên fb
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
        if(medicineList != null)
            return medicineList.size(); //phải cái này để trả về số lượng item
        return 0;
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
        LinearLayout layout_content;
        ImageView ivPic;
        TextView tvNameProduct, tvPrice;
        ImageButton imgBtnDelete;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            ivPic = itemView.findViewById(R.id.ivPic);
            tvNameProduct = itemView.findViewById(R.id.tvNameProduct);
            tvPrice = itemView.findViewById(R.id.tvPrice);
            layout_item = itemView.findViewById(R.id.layout_item);
            imgBtnDelete = itemView.findViewById(R.id.imgBtnDelete);
            layout_content= itemView.findViewById(R.id.layout_content);

        }
    }

}
