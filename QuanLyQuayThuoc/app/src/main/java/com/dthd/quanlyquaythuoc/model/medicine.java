package com.dthd.quanlyquaythuoc.model;

import java.io.Serializable;

public class medicine implements Serializable {
    private String id, name, details, pic, date;
    private int price, amount;
    private company company;

    public medicine() {

    }

    public medicine(String id, String name, String details, String pic, String date, int price, int amount, company company) {
        this.id = id;
        this.name = name;
        this.details = details;
        this.pic = pic;
        this.date = date;
        this.price = price;
        this.amount = amount;
        this.company = company;
    }

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
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

    public String getDetails() {
        return details;
    }

    public void setDetails(String details) {
        this.details = details;
    }

    public String getPic() {
        return pic;
    }

    public void setPic(String pic) {
        this.pic = pic;
    }

    public int getPrice() {
        return price;
    }

    public void setPrice(int price) {
        this.price = price;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }

    public com.dthd.quanlyquaythuoc.model.company getCompany() {
        return company;
    }

    public void setCompany(com.dthd.quanlyquaythuoc.model.company company) {
        this.company = company;
    }
}
