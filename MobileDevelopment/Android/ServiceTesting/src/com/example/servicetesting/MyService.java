package com.example.servicetesting;

import android.app.Service;
import android.content.Intent;
import android.os.IBinder;
import android.widget.Toast;

public class MyService extends Service {

	@Override
	public IBinder onBind(Intent arg0) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public void onCreate() {
		Toast.makeText(this, "Created", Toast.LENGTH_SHORT).show();
		super.onCreate();
		
	}

	@Override
	public void onDestroy() {
		Toast.makeText(this, "Destroyed", Toast.LENGTH_SHORT).show();
		super.onDestroy();
		
	}

	
	@Override
	public int onStartCommand(Intent intent, int flags, int startId) {
		
		Toast.makeText(this, "Started", Toast.LENGTH_SHORT).show();
		return super.onStartCommand(intent, flags, startId);
	}
	

}
