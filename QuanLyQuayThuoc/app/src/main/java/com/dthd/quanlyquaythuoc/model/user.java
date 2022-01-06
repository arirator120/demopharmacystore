package com.dthd.quanlyquaythuoc.model;

import java.io.Serializable;

public class user implements Serializable {

    private String id, name, phone, email;
    private String role;
    private boolean sex; //1:nam, 0:nu


    public user() {
    }

    public user(String id, String name, String phone, String email, String role, boolean sex) {
        this.id = id;
        this.name = name;
        this.phone = phone;
        this.email = email;
        this.role = role;
        this.sex = sex;
    }

    public boolean isSex() {
        return sex;
    }

    public void setSex(boolean sex) {
        this.sex = sex;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }
}
