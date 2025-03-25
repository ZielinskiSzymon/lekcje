package com.example.pierwszyprojekt;

import android.os.Bundle;
import android.text.Editable;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {
    // Tworze zmienne do powiazania z komponentam

    TextView textView;
    EditText editText;
    Button btn1, btn2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        textView = findViewById(R.id.tvMainTextView);
        editText = findViewById(R.id.editText);
        btn1 = findViewById(R.id.BtnShowToast);
        btn2 = findViewById(R.id.BtnShowText);

        // nasłuchiwacze

        //tak lepiej
        btn1.setOnClickListener(view -> showToastWithText(editText.getText()));

        btn2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                showTextInTextView(editText.getText());
            }
        });
    }

    private void showTextInTextView(Editable text) {
        textView.setText(text);
    }

    private void showToastWithText(Editable text) {
        Toast.makeText(getApplicationContext(), text, Toast.LENGTH_SHORT).show();
    }
}