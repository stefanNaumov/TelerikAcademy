//
//  ViewController.m
//  EventManagerApplication
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "MainViewController.h"

@interface MainViewController ()

@end

@implementation MainViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    if (!self.eventManager) {
        self.eventManager = [[EventManager alloc] init];
    }
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)addEvent:(id)sender {
    
    NSString *eventTitle = self.eventTitleInput.text;
    NSDate *eventDate = self.datePicker.date;
    
    Event *newEvent = [[Event alloc] init];
    [newEvent setTitle:eventTitle];
    [newEvent setDate:eventDate];
    
    [self.eventManager createEvent:newEvent];
    
    //clear input field
    self.eventTitleInput.text = @"";
    
    [self.eventTitleInput resignFirstResponder];
    
}

-(void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender{
    
    EventsListViewController *controller = [segue destinationViewController];
    [controller setEvents:self.eventManager.eventsList];
}

-(IBAction)unwindToMain:(UIStoryboardSegue *) segue{
    
}


@end
