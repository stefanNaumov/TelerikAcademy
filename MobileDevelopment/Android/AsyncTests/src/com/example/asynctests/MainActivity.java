package com.example.asynctests;

import android.support.v7.app.ActionBarActivity;
import android.app.Activity;
import android.app.ProgressDialog;
import android.content.Intent;
import android.content.SharedPreferences;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.preference.Preference;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.app.ActionBar;
public class MainActivity extends Activity implements OnClickListener {

	Button sendBtn;
	EditText textInput;
	ProgressDialog dl;
	private final static int ActivityFirst = 1;
	private final static int ActivitySecond = 2;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		textInput = (EditText) findViewById(R.id.editText1);
		sendBtn = (Button) findViewById(R.id.button1);

		sendBtn.setOnClickListener(this);
	}
	
	public boolean onCreateOptionsMenu(Menu menu) {
		
		getMenuInflater().inflate(R.menu.main, menu);
		
		return true;
	};
	 
	@Override
	protected void onPause() {
		
		super.onPause();
		SharedPreferences pref =  getSharedPreferences("MainActivity", 0);
		SharedPreferences.Editor editor = pref.edit();
		
		editor.putString("textvalue", textInput.getText().toString());
		
		editor.commit();
	}

	@Override
	protected void onResume() {
		super.onResume();
		
		SharedPreferences pref = getSharedPreferences("MainActivity", 0);
		
		String textVal = pref.getString("textvalue", null);
		
		if (textVal != null) {
			textInput.setText(textVal);
		}
		
	}

	@Override
	public void onClick(View arg0) {
		// textInput.setText("pesho");

		if (arg0.getId() == R.id.button1) {
			
			AsyncClass asClass = new AsyncClass();
			
			//asClass.execute(4);
			
			Intent in = new Intent(this, SecondActivity.class);
			//Intent in = new Intent(Intent.ACTION_VIEW,Uri.parse("http://telerikacademy.com"));
			String value = textInput.getText().toString();
			in.putExtra("textInput", value);
			startActivityForResult(in, 1);	
	
		}
	}
	
	@Override
	protected void onActivityResult(int requestCode, int resultCode, Intent data) {
		// TODO Auto-generated method stub
		super.onActivityResult(requestCode, resultCode, data);
		
		if (requestCode == ActivityFirst) {
			if (resultCode == RESULT_OK) {
				textInput.setText(data.getStringExtra("TextOutput"));
			}
		}
	}

	private class AsyncClass extends AsyncTask<Integer, Integer, Void>{

		@Override
		protected Void doInBackground(Integer... params) {
			try {
				Integer paramsArr[] = new Integer[2];
				paramsArr[0] = 0;
				paramsArr[1] = params[0];
				publishProgress(paramsArr);
				
				for (int i = 1; i <= params[0]; i++) {
					
					paramsArr[0] = i;
					paramsArr[1] = params[0];
					Thread.sleep(1000);
					publishProgress(paramsArr);
				}
				
			} catch (InterruptedException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			return null;
		}

		@Override
		protected void onProgressUpdate(Integer... values) {
			
			dl.setMessage("Done:" + values[0].toString() + "/" + values[1].toString());
			super.onProgressUpdate(values);
		}

		@Override
		protected void onPostExecute(Void result) {
			// TODO Auto-generated method stub
			super.onPostExecute(result);
			dl.hide();
		}

		@Override
		protected void onPreExecute() {
			dl = ProgressDialog.show(MainActivity.this, "Downloading","");
			super.onPreExecute();
		}
		
	}
}
