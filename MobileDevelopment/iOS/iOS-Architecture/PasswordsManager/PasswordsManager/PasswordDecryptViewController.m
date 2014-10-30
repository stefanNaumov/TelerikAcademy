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
    NSString *password = [self.password password];
    
    if ([[self.password encryptionCode] isEqualToString:encryptCodeInput]) {
        NSData *plainData = [password dataUsingEncoding:NSUTF8StringEncoding];
        NSData *decryptedData = [plainData AES256decryptWithKey:encryptCodeInput];
        
        NSString *decryptedStr = [[NSString alloc] initWithData:decryptedData encoding:NSASCIIStringEncoding];
        
        self.decryptedPassword.text = decryptedStr;
        
    }
    else{
        
    }
    
    [self.encryptionCode resignFirstResponder];
}

-(void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event{
    [self.view endEditing:TRUE];
}

@end
