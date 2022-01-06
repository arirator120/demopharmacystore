package com.dthd.quanlyquaythuoc.model;

import java.util.List;

public class bill {
    private String id, nameEmployee ,nameClient, phone, address, idEmployee;
    private int sum;
    private String date;
    private List<cart> lstCart;

    public bill() {
    }

    public bill(String id, String nameEmployee, String nameClient, String phone, String address, String idEmployee, int sum, String date, List<cart> lstCart) {
        this.id = id;
        this.nameEmployee = nameEmployee;
        this.nameClient = nameClient;
        this.phone = phone;
        this.address = address;
        this.idEmployee = idEmployee;
        this.sum = sum;
        this.date = date;
        this.lstCart = lstCart;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getNameClient() {
        return nameClient;
    }

    public void setNameClient(String nameClient) {
        this.nameClient = nameClient;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getNameEmployee() {
        return nameEmployee;
    }

    public void setNameEmployee(String nameEmployee) {
        this.nameEmployee = nameEmployee;
    }

    public List<cart> getLstCart() {
        return lstCart;
    }

    public void setLstCart(List<cart> lstCart) {
        this.lstCart = lstCart;
    }

    public String getIdEmployee() {
        return idEmployee;
    }

    public void setIdEmployee(String idEmployee) {
        this.idEmployee = idEmployee;
    }

    public int getSum() {
        return sum;
    }

    public void setSum(int sum) {
        this.sum = sum;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }
}
