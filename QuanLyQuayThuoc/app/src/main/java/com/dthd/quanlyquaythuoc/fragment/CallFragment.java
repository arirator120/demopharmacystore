package com.dthd.quanlyquaythuoc.fragment;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;

import androidx.cardview.widget.CardView;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;

import com.dthd.quanlyquaythuoc.R;
import com.dthd.quanlyquaythuoc.activity.client.ClientHomeActivity;
import com.dthd.quanlyquaythuoc.activity.employee.EmployeeHomeActivity;

/**
 * A simple {@link Fragment} subclass.
 * create an instance of this fragment.
 */
public class CallFragment extends Fragment {

    CardView layout_itemHelp;

    public CallFragment() {
        // Required empty public constructor
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View v = inflater.inflate(R.layout.fragment_call, container, false);
        ((ClientHomeActivity)getActivity()).getSupportActionBar().setTitle("Liên hệ đặt hàng");
        layout_itemHelp = v.findViewById(R.id.layout_itemHelp);
        layout_itemHelp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent iCall = new Intent(Intent.ACTION_DIAL, Uri.parse("tel:"+ "0937435006"));
                getActivity().startActivity(iCall);
            }
        });
        return v;
    }
}