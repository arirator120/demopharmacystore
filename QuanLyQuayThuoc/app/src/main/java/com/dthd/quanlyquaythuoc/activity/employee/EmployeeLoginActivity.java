package com.dthd.quanlyquaythuoc.activity.employee;

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
import com.dthd.quanlyquaythuoc.activity.client.ClientHomeActivity;
import com.dthd.quanlyquaythuoc.activity.client.ClientLoginActivity;
import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;

public class EmployeeLoginActivity extends AppCompatActivity {

    FirebaseAuth mAuth;
    FirebaseUser mUser;

    EditText etEmail, etPassword;
    Button btnLogin;
    String patternEmail = "[a-zA-Z0-9._-]+@[a-z]+\\.+[a-z]+";
    ProgressDialog dialogBar;
    TextView tvLogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_employee_login);

        init();
        dialogBar = new ProgressDialog(this);
        mAuth = FirebaseAuth.getInstance();
        mUser = mAuth.getCurrentUser();

        if(mUser != null){
            startActivity(new Intent(getApplicationContext(), EmployeeHomeActivity.class));
            finish();
        }


        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                authCheck();
            }
        });

        //đưa về trang đăng nhập client
        tvLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(getApplicationContext(), ClientLoginActivity.class));
            }
        });

    }

    public void init(){
        tvLogin = findViewById(R.id.tvLogin);
        etEmail = findViewById(R.id.etEmail);
        etPassword = findViewById(R.id.etPassword);
        btnLogin = findViewById(R.id.btnLogin);
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
            // những tên miền không phải nhân viên thì hk dc vào trang nhân viên
            if(!domainEmail.equals("@pharmacity.com")){
                Toast.makeText(EmployeeLoginActivity.this, "Tên miền này không được đăng nhập ở đây", Toast.LENGTH_SHORT).show();
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
                        accessUser(email);
                        Toast.makeText(EmployeeLoginActivity.this, "Đăng nhập thành công", Toast.LENGTH_SHORT).show();
                    }else{
                        dialogBar.dismiss();
                        Toast.makeText(EmployeeLoginActivity.this, "Tài khoản/Mật khẩu không đúng", Toast.LENGTH_SHORT).show();
                    }
                }
            });
        }
    }

    private void accessUser(String email){
            Intent i = new Intent(EmployeeLoginActivity.this, (email.equals("admin@pharmacity.com")) ?  AdminHomeActivity.class : EmployeeHomeActivity.class);
            startActivity(i);

    }
}