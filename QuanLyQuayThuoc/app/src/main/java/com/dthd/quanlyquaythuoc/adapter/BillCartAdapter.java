package com.dthd.quanlyquaythuoc.adapter;

import android.content.Context;
import android.content.DialogInterface;
import android.net.Uri;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.model.cart;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class BillCartAdapter extends RecyclerView.Adapter<BillCartAdapter.ViewHolder>{
    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;
    int sum;

    private List<cart> cartList;
    private Context mContext;
    private TextView tvSum;

    public BillCartAdapter(List<cart> cartList, Context mContext, TextView tvSum) {
        this.cartList = cartList;
        this.mContext = mContext;
        this.tvSum = tvSum;
    }

    @NonNull
    @Override
    public BillCartAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_bill,parent,false);
        BillCartAdapter.ViewHolder holder = new BillCartAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull BillCartAdapter.ViewHolder holder, int position) {
        cart c = cartList.get(position);
        if(c==null)
            return;

        holder.tvNameProduct.setText(c.getMedicine().getName());
        String priceFormat = String.format("%,d",c.getMedicine().getPrice());
        String price = priceFormat.replace(",","."); //thay , thành .
        holder.tvPrice.setText(price);
        holder.tvAmount.setText("x " + c.getAmount());
        Glide.with(mContext)
                .load(String.valueOf(Uri.parse(c.getMedicine().getPic())))
                .into(holder.ivPic); //ho tro doc uri

        priceFormat = String.format("%,d",sumList(cartList));
        price = priceFormat.replace(",","."); //thay , thành .
        tvSum.setText( price + ",00VNĐ");
    }

    public int sumList(List<cart> cartList){
        sum = 0;
        for (int i= 0; i < cartList.size(); i++){
            cart c =  cartList.get(i);
            sum += (c.getMedicine().getPrice() * c.getAmount()); //khi t.tong tien cập nhật thì giá trị tongtien trong listOrder cũng cập nhật
        }
        return sum;
    }


    public void release(){
        mContext=null;
    }

    @Override
    public int getItemCount() {
        if(cartList != null)
            return cartList.size(); //phải cái này để trả về số lượng item
        return 0;
    }


    public class ViewHolder extends RecyclerView.ViewHolder {
        CardView layout_item;
        ImageView ivPic;
        TextView tvNameProduct, tvPrice, tvAmount;


        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            ivPic = itemView.findViewById(R.id.ivPic);
            tvNameProduct = itemView.findViewById(R.id.tvNameProduct);
            tvPrice = itemView.findViewById(R.id.tvPrice);
            layout_item = itemView.findViewById(R.id.layout_item);
            tvAmount = itemView.findViewById(R.id.tvAmount);
        }
    }
}
