//
//  SecondViewController.m
//  CustomTabBar
//
//  Created by admin on 11/2/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "SecondViewController.h"

@interface SecondViewController ()

@end

@implementation SecondViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    NSArray *elementsInNib = [[NSBundle mainBundle] loadNibNamed:@"View" owner:nil options:nil];
    CustomView *customView = [elementsInNib lastObject];
    customView.textView.text = @"This is the second custom view";
    self.customView = customView;
    [self.view addSubview:self.customView];
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
