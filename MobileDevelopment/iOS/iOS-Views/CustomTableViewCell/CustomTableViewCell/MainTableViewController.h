//
//  MainTableViewController.h
//  CustomTableViewCell
//
//  Created by admin on 11/1/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "CustomUITableViewCell.h"
#import "Image.h"

@interface MainTableViewController : UITableViewController

@property NSMutableArray *images;

-(void) initImages;

@end
