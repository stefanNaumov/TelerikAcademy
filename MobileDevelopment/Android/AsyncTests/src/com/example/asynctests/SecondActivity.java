package com.example.asynctests;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class SecondActivity extends Activity implements OnClickListener{
	
	private EditText output;
	private Button b;
	
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_second);
		
		output = (EditText)findViewById(R.id.editOutput);
		b = (Button)findViewById(R.id.btnSecond1);
		
		b.setOnClickListener(this);
	}

	@Override
	protected void onResume() {
		// TODO Auto-generated method stub
		super.onResume();
				
		Intent intent = this.getIntent();
		
		String getInput = intent.getStringExtra("textInput");
		
		output.setText(getInput);
	}

	@Override
	public void onClick(View v) {
		//Toast t = Toast.makeText(this, "Switching activity", Toast.LENGTH_SHORT);
		//t.show();
		
		AlertDialog.Builder dialog = new AlertDialog.Builder(this);
		dialog.setMessage("Break it?");
		dialog.setPositiveButton("Yes", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				Toast t = Toast.makeText(SecondActivity.this, "You broke it", Toast.LENGTH_SHORT);
				t.show();
				
			}
		});
		dialog.setNegativeButton("No", new DialogInterface.OnClickListener() {
			
			@Override
			public void onClick(DialogInterface dialog, int which) {
				Toast t = Toast.makeText(SecondActivity.this, "You didn't broke it", Toast.LENGTH_SHORT);
				t.show();
				
			}
		});
		dialog.create().show();
		//Intent in = new Intent();
		//in.putExtra("TextOutput", output.getText().toString());
		//setResult(RESULT_OK, in);
		
		//finish();
		
	}
	
}
