//
//  ViewController.h
//  EventManagerApp
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>



@interface MainViewController : UIViewController
@property (weak, nonatomic) IBOutlet UIDatePicker *datePicker;
@property (weak, nonatomic) IBOutlet UITextField *eventTitleInput;
- (IBAction)addEvent:(id)sender;

@end

