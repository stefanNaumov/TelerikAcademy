//
//  FirstViewController.m
//  CustomTabBar
//
//  Created by admin on 11/2/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "FirstViewController.h"

@interface FirstViewController ()

@end

@implementation FirstViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    
    NSArray *elementsInNib = [[NSBundle mainBundle] loadNibNamed:@"View" owner:nil options:nil];
    CustomView *customView = [elementsInNib lastObject];
    customView.textView.text = @"This is the first custom view";
    customView.textView.textColor = [UIColor blackColor];
    
    self.customView = customView;
    [self.view addSubview:self.customView];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
