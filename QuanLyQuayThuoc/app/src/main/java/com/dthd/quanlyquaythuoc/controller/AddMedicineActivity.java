package com.dthd.quanlyquaythuoc.controller;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.Toast;

import com.bumptech.glide.Glide;
import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.fragment.ManagerEmployeeFragment;
import com.dthd.quanlyquaythuoc.fragment.ManagerMedicinesFragment;
import com.dthd.quanlyquaythuoc.model.company;
import com.dthd.quanlyquaythuoc.model.medicine;
import com.google.android.gms.tasks.OnFailureListener;
import com.google.android.gms.tasks.OnSuccessListener;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import com.google.android.material.tabs.TabLayout;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;
import com.google.firebase.storage.FirebaseStorage;
import com.google.firebase.storage.StorageReference;
import com.google.firebase.storage.UploadTask;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
import java.util.Locale;

public class AddMedicineActivity extends AppCompatActivity {

    FirebaseDatabase mDatabase = FirebaseDatabase.getInstance();
    DatabaseReference _myRef;

    Uri imageUri;
    StorageReference storageReference;

    Button selectImagebtn;
    EditText etNameProduct,etPrice,etDetails,etDate, etAmount;
    Spinner spCompany;
    Bundle bundle;
    ImageView firebaseImage;

    boolean flag = false; //nhan bik add hay edit


    BottomNavigationView bottomNavigationView;
    List<company> lstCompanies;
    ArrayAdapter<company> adapter_company;
    medicine m;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_add_medicine);


        bundle =  getIntent().getExtras();
        inIt();
        inItCompany();

        etDate.setText(getDateTime());

        etDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                pickDay();
            }
        });

        selectImagebtn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {


                selectImage();


            }
        });

        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                int id = item.getItemId();

                if(id == R.id.menu_bottom_save){
                    if(errorMsg() == ""){
                        setData(m);

                    }else{
                        Toast.makeText(AddMedicineActivity.this, errorMsg(), Toast.LENGTH_LONG).show();
                        return false;
                    }

                }
                finish();
                return false;

            }

        });
    }

    public void inItCompany(){
        _myRef = mDatabase.getReference("Companies");
        lstCompanies = new ArrayList<>();
        _myRef.addValueEventListener(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot snapshot) {
                if(lstCompanies != null || !lstCompanies.isEmpty())
                    lstCompanies.clear();

                if (snapshot.exists()) {
                    for (DataSnapshot dataSnapshot : snapshot.getChildren()) {

                        company c = dataSnapshot.getValue(company.class);
                        lstCompanies.add(c);
                    }
                    adapter_company.notifyDataSetChanged();
                    getData(lstCompanies); //cẩn thận
                }


            }

            @Override
            public void onCancelled(@NonNull DatabaseError error) {

            }
        });

        //Log.d("Check", lstGuarantee.size() + "");
        adapter_company = new ArrayAdapter(AddMedicineActivity.this, android.R.layout.simple_spinner_item, lstCompanies);


        adapter_company.setDropDownViewResource(android.R.layout.simple_list_item_single_choice);
        spCompany.setAdapter(adapter_company);
    }
    public void inIt(){
        etNameProduct =  findViewById(R.id.etNameProduct);
        etPrice =  findViewById(R.id.etPrice);
        etAmount =  findViewById(R.id.etAmount);
        etDetails  =  findViewById(R.id.etDetails);
        etDate =  findViewById(R.id.etDate);
        spCompany = findViewById(R.id.spCompany);
        bottomNavigationView = findViewById(R.id.bottom_navigation);
        selectImagebtn = findViewById(R.id.selectImagebtn);
        firebaseImage = findViewById(R.id.firebaseImage);
    }

    private String getDateTime() {
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd/MM/yy");
        Date date = new Date();
        return dateFormat.format(date);
    }

    private void pickDay(){
        final Calendar calendar = Calendar.getInstance();
        int day = calendar.get(Calendar.DATE);
        int month = calendar.get(Calendar.MONTH);
        int year = calendar.get(Calendar.YEAR);
        DatePickerDialog datePickerDialog;
        datePickerDialog = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int i, int i1, int i2) {
                calendar.set(i,i1,i2);
                SimpleDateFormat simpleDateFormat = new SimpleDateFormat("dd/MM/yy");
                etDate.setText(simpleDateFormat.format(calendar.getTime()));
            }
        }, year, month, day); // bắt buộc phải lần lượt là year, month,day để lấy đúng ngày hiện tại
        datePickerDialog.show();
    }

    public void getData(List<company> lstCompanies){
        //nếu mà kh có dl lập tức skip phần còn lại bên dưới
        //khi bundle có dữ liệu tức là từ viewPerson gửi qua-> flag= true
        if(bundle == null){
            return;
        }
        flag = true; //edit
        m = (medicine) bundle.get("object_medicines");
        etNameProduct.setText(m.getName());
        etPrice.setText(m.getPrice() + "");
        etAmount.setText(m.getAmount()+ "");
        etDetails.setText(m.getDetails());
        Glide.with(getApplicationContext())
                .load(String.valueOf(Uri.parse(m.getPic())))
                .into(firebaseImage);

        //Log.d("Check", ins.isStatus() + "");

        for(int i = 0; i < lstCompanies.size(); i++){
            if(lstCompanies.get(i).getId().equals(m.getCompany().getId())) {
//                Log.d("Check", lstGuarantee.get(i).getTime() + "");
                spCompany.setSelection(i);
                break;
            }
        }
    }

    //xong//
    public void setData(medicine m){
        //nếu đối tượng rỗng
        if(m==null)
            m = new medicine(); //khởi tạo object

        m.setName(etNameProduct.getText().toString());
        m.setPrice(Integer.parseInt(etPrice.getText().toString()));
        m.setAmount(Integer.parseInt(etAmount.getText().toString()));
        m.setDate(etDate.getText().toString());
        m.setDetails(etDetails.getText().toString());
        m.setCompany((company) spCompany.getSelectedItem());
        _myRef = mDatabase.getReference("Medicines");
        setFirebaseImage(m);

        //Log.d("mess",ins.isStatus()+ "");

    }

    private void selectImage() {

        Intent intent = new Intent();
        intent.setType("image/*");
        intent.setAction(Intent.ACTION_GET_CONTENT);
        startActivityForResult(intent,100);

    }

    private void setFirebaseImage(medicine m){
        SimpleDateFormat formatter = new SimpleDateFormat("yyyy_MM_dd_HH_mm_ss", Locale.CANADA);
        Date now = new Date();
        String fileName = formatter.format(now);

        FirebaseStorage firebaseStorage = FirebaseStorage.getInstance();
        StorageReference storageReferenceProfilePic = firebaseStorage.getReference();
        storageReference = storageReferenceProfilePic.child("images/"+fileName + ".jpg");
        if(imageUri != null){
            storageReference.putFile(imageUri)
                    .addOnSuccessListener(new OnSuccessListener<UploadTask.TaskSnapshot>() {
                        @Override
                        public void onSuccess(UploadTask.TaskSnapshot taskSnapshot) {
//                        firebaseImage.setImageURI(null);
                            storageReference.getDownloadUrl()
                                    .addOnSuccessListener(new OnSuccessListener<Uri>() {
                                        @Override
                                        //khi file chưa exist trên fb
                                        public void onSuccess(Uri uri) {
                                            String uriString = uri.toString();
                                            m.setPic(uriString);
                                            if(flag == false){
                                                //add
                                                String id = _myRef.push().getKey();
                                                m.setId(id);
                                                _myRef.child(m.getId()).setValue(m); //tạo value cho nhánh trên fb
                                                Toast.makeText(AddMedicineActivity.this,"Thêm sản phẩm thành công!!",Toast.LENGTH_SHORT).show();
                                            }
                                            else{
                                                //edit
                                                _myRef.child(m.getId()).setValue(m); //thay đổi giá trị theo getdata thông qua biến ins
                                                Intent i = new Intent(AddMedicineActivity.this, ManagerMedicinesFragment.class);
                                                startService(i);
                                                //finish();
                                                Toast.makeText(AddMedicineActivity.this,"Cập nhật sản phẩm thành công!!",Toast.LENGTH_SHORT).show();

                                            }
                                        }
                                    });
                        }
                    })
                    .addOnFailureListener(new OnFailureListener() {
                        @Override
                        public void onFailure(@NonNull Exception e) {
                            //Chỉ xảy ra khi ng dùng hk edit ảnh
                            Toast.makeText(AddMedicineActivity.this,"Failed upload",Toast.LENGTH_SHORT).show();
                        }
                    });
        }else{
            if(flag == true){
                //edit
                _myRef.child(m.getId()).setValue(m); //thay đổi giá trị theo getdata thông qua biến ins
                Intent i = new Intent(AddMedicineActivity.this, ManagerMedicinesFragment.class);
                startService(i);
                //finish();
                Toast.makeText(AddMedicineActivity.this,"Cập nhật sản phẩm thành công!!",Toast.LENGTH_SHORT).show();
            }
        }



    }

    //ktra có lỗi hay hk
    private String errorMsg(){
        //check lenght cua price < 10 chữ số
        if(etNameProduct.getText().toString().isEmpty())
            return "Vui lòng nhập tên sản phẩm!";
        if(etPrice.getText().toString().isEmpty())
            return "Vui lòng nhập giá bán!";
        if(etAmount.getText().toString().isEmpty())
            return "Vui lòng nhập số lượng!";
        if(etDate.getText().toString().isEmpty())
            return "Vui lòng nhập hạn sử dụng!";
        if(firebaseImage.getDrawable() == null)
            return  "Vui lòng chọn ảnh sản phẩm!";
        return "";
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == 100 && data != null && data.getData() != null){

            imageUri = data.getData();
            firebaseImage.setImageURI(imageUri); // đưa ảnh đã chọn lên giao diện


        }
    }




}