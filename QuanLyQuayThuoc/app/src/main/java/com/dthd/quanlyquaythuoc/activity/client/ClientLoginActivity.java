package com.dthd.quanlyquaythuoc.activity.client;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.app.ProgressDialog;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.employee.EmployeeLoginActivity;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;

public class ClientLoginActivity extends AppCompatActivity {
    FirebaseAuth mAuth;
    FirebaseUser mUser;

    EditText etEmail, etPassword;
    Button btnLogin;
    String patternEmail = "[a-zA-Z0-9._-]+@[a-z]+\\.+[a-z]+";
    ProgressDialog dialogBar;

    TextView tvChangeRole,tvRegister;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_client_login);
        init();
        dialogBar = new ProgressDialog(this);
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        if(mUser != null){
            startActivity(new Intent(getApplicationContext(), ClientHomeActivity.class));
            finish();
        }


        tvRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(getApplicationContext(), ClientRegisterActivity.class));
            }
        });

        tvChangeRole.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(getApplicationContext(), EmployeeLoginActivity.class));
            }
        });

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                authCheck();
            }
        });

    }


    public void init(){
        tvRegister = findViewById(R.id.tvRegister);
        etEmail = findViewById(R.id.etEmail);
        etPassword = findViewById(R.id.etPassword);
        btnLogin = findViewById(R.id.btnLogin);
        tvChangeRole = findViewById(R.id.tvChangeRole);
    }

    public void authCheck(){
        String email =  etEmail.getText().toString().trim();
        String password = etPassword.getText().toString();
        if(email.isEmpty())
            etEmail.setError("Vui lòng nhập email");
        else if(!email.matches(patternEmail))
            etEmail.setError("Email không hợp hệ");
        else if(password.isEmpty())
            etPassword.setError("Vui lòng nhập mật khẩu");
        else{
            //nhập dữ liệu đầy đủ rồi thì vào đây
            int posDomain = email.indexOf('@');
            String domainEmail = email.substring(posDomain);
            Log.d("domain",domainEmail);
            //Không cho những tên miền nhân viên vào trang khách hàng
            if(domainEmail.equals("@pharmacity.com")){
                Toast.makeText(ClientLoginActivity.this, "Tên miền này không được đăng nhập ở đây", Toast.LENGTH_SHORT).show();
                return;
            }


            dialogBar.setMessage("Vui lòng chờ trong giây lát");
            dialogBar.setTitle("Đăng nhập");
            dialogBar.setCanceledOnTouchOutside(false);
            dialogBar.show();

            //create user
            mAuth.signInWithEmailAndPassword(email,password).addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                @Override
                public void onComplete(@NonNull Task<AuthResult> task) {
                    if(task.isSuccessful()){
                        dialogBar.dismiss();
                        accessUser();
                        Toast.makeText(ClientLoginActivity.this, "Đăng nhập thành công", Toast.LENGTH_SHORT).show();
                    }else{
                        dialogBar.dismiss();
                        Toast.makeText(ClientLoginActivity.this, "Tài khoản/Mật khẩu không đúng", Toast.LENGTH_SHORT).show();
                    }
                }
            });
        }
    }

    private void accessUser(){
        Intent i = new Intent(ClientLoginActivity.this, ClientHomeActivity.class);
        startActivity(i);

    }


}