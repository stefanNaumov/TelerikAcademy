package com.example.servicetesting;

import android.support.v7.app.ActionBarActivity;
import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public class MainActivity extends Activity implements OnClickListener{

	private Button start,stop;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		start = (Button)findViewById(R.id.btn_start);
		stop = (Button)findViewById(R.id.btn_stop);
		
		start.setOnClickListener(this);
		
		stop.setOnClickListener(this);
	}

	@Override
	public void onClick(View v) {

		Intent in = new Intent(this, MyService.class);
		
		if (v.getId() == start.getId()) {
			startService(in);
		}
		else {
			stopService(in);
		}
		
	}

	
}
