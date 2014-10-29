//
//  PasswordDecryptViewController.m
//  PasswordsManager
//
//  Created by admin on 10/29/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "PasswordDecryptViewController.h"

@implementation PasswordDecryptViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    self.encryptedPassword.text = [self.password password];
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)decrypt:(id)sender {
    
    NSString *encryptCodeInput = self.encryptionCode.text;
    [self.encryptionCode resignFirstResponder];
    
    if ([[self.password encryptionCode] isEqualToString:encryptCodeInput]) {
        //TODO add decryption logic
        NSLog(@"WORKING");
    }
    else{
        
    }
}

-(void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event{
    [self.view endEditing:TRUE];
}
@end
