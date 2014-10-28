//
//  ViewController.h
//  EventManagerApplication
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "EventManager.h"
#import "Event.h"
#import "EventsListViewController.h"

@interface MainViewController : UIViewController{
    
}

@property (weak, nonatomic) IBOutlet UIDatePicker *datePicker;

@property (weak, nonatomic) IBOutlet UITextField *eventTitleInput;

@property (nonatomic) EventManager *eventManager;

- (IBAction)addEvent:(id)sender;

@end

