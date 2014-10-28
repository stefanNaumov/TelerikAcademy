//
//  EventsListViewController.h
//  EventManagerApplication
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Event.h"

@interface EventsListViewController : UIViewController<UITableViewDataSource,
UITableViewDelegate>
@property (weak, nonatomic) IBOutlet UITableView *tableView;

@property (nonatomic) NSArray *events;

@end
