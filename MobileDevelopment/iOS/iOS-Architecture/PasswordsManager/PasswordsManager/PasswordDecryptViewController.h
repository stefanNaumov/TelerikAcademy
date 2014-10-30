//
//  PasswordDecryptViewController.h
//  PasswordsManager
//
//  Created by admin on 10/29/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Password.h"
#import "AES256.h"

@interface PasswordDecryptViewController : UIViewController

@property (weak, nonatomic) IBOutlet UILabel *encryptedPassword;


@property (weak, nonatomic) IBOutlet UITextField *encryptionCode;

@property (weak, nonatomic) IBOutlet UILabel *decryptedPassword;

@property (nonatomic) Password *password;

- (IBAction)decrypt:(id)sender;

@end
