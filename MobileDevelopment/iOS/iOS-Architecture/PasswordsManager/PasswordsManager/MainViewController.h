//
//  ViewController.h
//  PasswordsManager
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Password.h"
#import "PasswordsTableViewController.h"

@interface MainViewController : UIViewController
@property (weak, nonatomic) IBOutlet UITextField *accountName;
@property (weak, nonatomic) IBOutlet UITextField *password;
@property (weak, nonatomic) IBOutlet UITextField *encryptionCode;

@property (nonatomic) NSMutableArray *passwords;

- (IBAction)addPassword:(id)sender;

@end

