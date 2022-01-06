package com.dthd.quanlyquaythuoc.activity.client;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.google.android.gms.auth.api.signin.GoogleSignInAccount;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.ValueEventListener;

public class ClientRegisterActivity extends AppCompatActivity {
    FirebaseAuth mAuth;
    FirebaseUser mUser;

    EditText etFullName, etEmail, etPassword, etPhone, etConfirmPassword;
    Button btnRegister;
    TextView tvLogin;
    String patternEmail = "[a-zA-Z0-9._-]+@[a-z]+\\.+[a-z]+";
    ProgressDialog dialogBar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_client_register);
        init();
        dialogBar = new ProgressDialog(this);
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        if(mUser != null){
            startActivity(new Intent(getApplicationContext(), ClientHomeActivity.class));
            finish();
        }

        tvLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(getApplicationContext(), ClientLoginActivity.class));
            }
        });

        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                authCheck();
            }
        });





    }

    public void init(){
        etEmail = findViewById(R.id.etEmail);
        etFullName = findViewById(R.id.etFullName);
        etPassword = findViewById(R.id.etPassword);
        etPhone = findViewById(R.id.etPhone);
        btnRegister = findViewById(R.id.btnRegister);
        tvLogin = findViewById(R.id.tvLogin);
        etConfirmPassword = findViewById(R.id.etConfirmPassword);

    }

    public void authCheck(){
        String email =  etEmail.getText().toString().trim();
        String name =  etFullName.getText().toString();
        String phone =  etPhone.getText().toString();
        String password = etPassword.getText().toString();
        String confirmPassword = etConfirmPassword.getText().toString();

        if(email.isEmpty())
            etEmail.setError("Vui lòng nhập email");
        else if(!email.matches(patternEmail))
            etEmail.setError("Email không hợp hệ");
        else if(email.equals("admin@gmail.com") || email.equals("admin@pharmacity.com"))
            etEmail.setError("Email này đã tồn tại");
        else if(email.contains("@pharmacity.com"))
            etEmail.setError("@pharmacity.com chỉ dành cho nhân viên");
        else if(name.isEmpty())
            etFullName.setError("Vui lòng nhập họ tên");
        else if(phone.isEmpty())
            etPhone.setError("Vui lòng nhập số điện thoại");
        else if(password.isEmpty())
            etPassword.setError("Vui lòng nhập mật khẩu");
        else if(confirmPassword.isEmpty())
            etConfirmPassword.setError("Vui lòng nhập xác nhận mật khẩu");
        else if(!password.equals(confirmPassword))
            etConfirmPassword.setError("Xác nhận mật khẩu không đúng");
        else{
            dialogBar.setMessage("Vui lòng chờ trong giây lát");
            dialogBar.setTitle("Đăng ký");
            dialogBar.setCanceledOnTouchOutside(false);
            dialogBar.show();

            //create user
            mAuth.createUserWithEmailAndPassword(email,password).addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                @Override
                public void onComplete(@NonNull Task<AuthResult> task) {
                    if(task.isSuccessful()){
                        dialogBar.dismiss();
                        //next activity
                        accessUser();
                        Toast.makeText(ClientRegisterActivity.this, "Đăng ký thành công", Toast.LENGTH_SHORT).show();
                    }else{
                        dialogBar.dismiss();
                        Toast.makeText(ClientRegisterActivity.this, "Đăng ký thất bại", Toast.LENGTH_SHORT).show();
                    }
                }
            });
        }

    }

    private void accessUser(){
        Intent i = new Intent(ClientRegisterActivity.this, ClientHomeActivity.class);
        Bundle bundle = new Bundle();
        bundle.putString("object_name", etFullName.getText().toString());
        bundle.putString("object_phone", etPhone.getText().toString());
        i.putExtras(bundle);
        startActivity(i);

    }
}