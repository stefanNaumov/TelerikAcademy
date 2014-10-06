package com.example.customgridview;

import android.support.v7.app.ActionBarActivity;
import android.R.integer;
import android.app.Activity;
import android.app.ListActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.GridView;

public class MainActivity extends Activity {

	//String[] aa = {"pesho","gosho","dragop","stamat","pesho","gosho",
			//"dragop","stamat","pesho","gosho","dragop","stamat"};
	
	GridView grid;
	
	int[] imageIds = {
			R.drawable.car1,
			R.drawable.car2,
			R.drawable.car3,
			R.drawable.car4,
			R.drawable.car5,
			R.drawable.car6,
			R.drawable.car7,
			R.drawable.car8,
			R.drawable.car9,
			R.drawable.car10,
			R.drawable.car11,
			R.drawable.car12,
			R.drawable.car13,
		};
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		CustomGrid gridAdapter = new CustomGrid(this, imageIds);
		grid = (GridView)findViewById(R.id.grid);
		
		grid.setAdapter(gridAdapter);
	}

	
}
