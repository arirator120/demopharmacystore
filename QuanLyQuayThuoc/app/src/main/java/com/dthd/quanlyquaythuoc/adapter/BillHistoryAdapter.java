package com.dthd.quanlyquaythuoc.adapter;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.model.bill;


import java.util.List;

public class BillHistoryAdapter extends RecyclerView.Adapter<BillHistoryAdapter.ViewHolder>{

    private List<bill> billList;
    private Context mContext;

    public BillHistoryAdapter(List<bill> billList, Context mContext) {
        this.billList = billList;
        this.mContext = mContext;
    }


    @NonNull
    @Override
    public BillHistoryAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_history,parent,false);
        BillHistoryAdapter.ViewHolder holder = new BillHistoryAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull BillHistoryAdapter.ViewHolder holder, int position) {
        bill b = billList.get(position);
        if(b==null)
            return;

        holder.tvName.setText("Hóa đơn " + b.getNameEmployee() + " lập (Chưa thanh toán)");
        String priceFormat = String.format("%,d",b.getSum());
        String price = priceFormat.replace(",","."); //thay , thành .
        holder.tvPrice.setText(price);

        holder.tvDate.setText(b.getDate());

    }

    public void release(){
        mContext=null;
    }

    @Override
    public int getItemCount() {
        if(billList != null)
            return billList.size(); //phải cái này để trả về số lượng item
        return 0;
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
        LinearLayout layout_content;
        TextView tvName, tvPrice, tvDate;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            tvName = itemView.findViewById(R.id.tvName);
            tvPrice = itemView.findViewById(R.id.tvPrice);
            layout_item = itemView.findViewById(R.id.layout_item);
            tvDate = itemView.findViewById(R.id.tvDate);
            layout_content= itemView.findViewById(R.id.layout_content);

        }
    }
}
