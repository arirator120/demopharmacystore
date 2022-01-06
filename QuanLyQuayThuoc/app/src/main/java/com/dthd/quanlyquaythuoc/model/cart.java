package com.dthd.quanlyquaythuoc.model;

public class cart{
    private medicine medicine;
    private String id;
    private int amount;
    private String idUser;

    public cart() {
    }

    public cart(com.dthd.quanlyquaythuoc.model.medicine medicine, String id, int amount, String idUser) {
        this.medicine = medicine;
        this.id = id;
        this.amount = amount;
        this.idUser = idUser;
    }

    public String getIdUser() {
        return idUser;
    }

    public void setIdUser(String idUser) {
        this.idUser = idUser;
    }

    public com.dthd.quanlyquaythuoc.model.medicine getMedicine() {
        return medicine;
    }

    public void setMedicine(com.dthd.quanlyquaythuoc.model.medicine medicine) {
        this.medicine = medicine;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public int getAmount() {
        return amount;
    }

    public void setAmount(int amount) {
        this.amount = amount;
    }
}
