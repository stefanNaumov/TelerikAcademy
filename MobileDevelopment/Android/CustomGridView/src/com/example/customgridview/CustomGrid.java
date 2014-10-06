package com.example.customgridview;

import java.util.zip.Inflater;

import android.content.Context;
import android.media.Image;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;

public class CustomGrid extends BaseAdapter{
	private Context context;
	private int[] imageIds;
	
	public CustomGrid(Context context, int[] images) {
		this.context = context;
		this.imageIds = images;
	}

	@Override
	public int getCount() {
		// TODO Auto-generated method stub
		return this.imageIds.length;
	}

	@Override
	public Object getItem(int arg0) {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public long getItemId(int arg0) {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public View getView(int position, View view, ViewGroup parent) {
		View grid;
		LayoutInflater inflater = (LayoutInflater) context
				.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
		
		if (view == null) {
			grid = new View(context);
			grid = inflater.inflate(R.layout.grid_layout, null);
			
			ImageView imageView = (ImageView)grid.findViewById(R.id.grid_image);
			imageView.setImageResource(imageIds[position]);
		}
		else {
			grid = (View) view;
		}
		
		return grid;
	}

}
