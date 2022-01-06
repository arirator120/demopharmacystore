package com.dthd.quanlyquaythuoc.adapter;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.net.Uri;
import android.text.Html;
import android.view.LayoutInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
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
import com.dthd.quanlyquaythuoc.model.cart;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

import java.util.List;

public class CartAdapter extends RecyclerView.Adapter<CartAdapter.ViewHolder>{

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    FirebaseAuth mAuth;
    FirebaseUser mUser;

    private List<cart> cartList;
    private Context mContext;

    EditText etAmount;


    public CartAdapter(List<cart> medicineList, Context mContext) {
        this.cartList = medicineList;
        this.mContext = mContext;
    }

    @NonNull
    @Override
    public CartAdapter.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View v = LayoutInflater.from(parent.getContext()).inflate(R.layout.row_item_cart,parent,false);
        CartAdapter.ViewHolder holder = new CartAdapter.ViewHolder(v);
        return holder;
    }

    @Override
    public void onBindViewHolder(@NonNull CartAdapter.ViewHolder holder, int position) {
        cart c = cartList.get(position);
        if(c==null)
            return;

        holder.tvNameProduct.setText(c.getMedicine().getName());
        String priceFormat = String.format("%,d",c.getMedicine().getPrice());
        String price = priceFormat.replace(",","."); //thay , thành .
        holder.tvPrice.setText(price);
//        holder.tvAmount.setText(c.getAmount() + "");
        holder.tvAmount.setText(Html.fromHtml("<u>"+ (c.getAmount() + "") +"</u>"));


        Glide.with(mContext)
                .load(String.valueOf(Uri.parse(c.getMedicine().getPic())))
                .into(holder.ivPic); //ho tro doc uri


        holder.imgBtnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickDelete(c);

            }
        });

        holder.layout_content.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                onClickEdit(c);
            }
        });

    }

    private void onClickDelete(cart c) {
        new AlertDialog.Builder(mContext)
                .setTitle(mContext.getString(R.string.app_name))
                .setMessage("Bạn có chắc muốn xóa sản phẩm này?")
                .setPositiveButton("Xóa", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialogInterface, int i) {
                        _myRef = mDatabase.getReference("Carts");
                        _myRef.child(c.getId()).removeValue(); //xóa object trên fb
                        Toast.makeText(mContext, "Xóa thành công!!", Toast.LENGTH_SHORT).show();
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

    private void onClickEdit(cart c) {
        Dialog d = new Dialog(mContext);
        d.setContentView(R.layout.activity_edit_amount);

        etAmount = d.findViewById(R.id.etAmount);
        etAmount.setText(c.getAmount() + "");

        d.getWindow().setLayout(800,800);

        BottomNavigationView bottomNavigationView = d.findViewById(R.id.bottom_navigation);
        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {
                int id = item.getItemId();

                if(id == R.id.menu_bottom_save) {
                    if(!etAmount.getText().toString().isEmpty()){
                        setData(c);
                        Toast.makeText(mContext, "Cập nhật thành công!!", Toast.LENGTH_LONG).show();
                    }else{
                        Toast.makeText(mContext, "Số lượng ít nhất là 1!!", Toast.LENGTH_LONG).show();
                    }
                }

                d.dismiss();
                return false;
            }

        });

        d.show();

    }


    public void setData(cart c){
        if(c==null)
            c = new cart(); //khởi tạo object
        c.setAmount(Integer.parseInt(etAmount.getText().toString()));


        _myRef = mDatabase.getReference("Carts");

        _myRef.child(c.getId()).setValue(c); //thay đổi giá trị theo getdata thông qua biến ins

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
        TextView tvNameProduct, tvPrice;
        ImageButton imgBtnDelete;
        TextView tvAmount;
        LinearLayout layout_content;
        public ViewHolder(@NonNull View itemView) {
            super(itemView);
            ivPic = itemView.findViewById(R.id.ivPic);
            tvNameProduct = itemView.findViewById(R.id.tvNameProduct);
            tvPrice = itemView.findViewById(R.id.tvPrice);
            layout_item = itemView.findViewById(R.id.layout_item);
            imgBtnDelete = itemView.findViewById(R.id.imgBtnDelete);
            tvAmount = itemView.findViewById(R.id.tvAmount);
            layout_content= itemView.findViewById(R.id.layout_content);

        }
    }
}
