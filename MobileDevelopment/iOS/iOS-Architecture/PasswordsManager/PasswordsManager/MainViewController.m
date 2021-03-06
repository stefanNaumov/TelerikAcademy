//
//  ViewController.m
//  PasswordsManager
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "MainViewController.h"

@interface MainViewController ()
@end

#define trimAll(object)[object stringByTrimmingCharactersInSet:[NSCharacterSet whitespaceCharacterSet]]

@implementation MainViewController

-(id)initWithCoder:(NSCoder *)aDecoder{
    self = [super initWithCoder:aDecoder];
    if (self) {
        self.passwords = [[NSMutableArray alloc] init];
    }
    
    return self;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)addPassword:(id)sender {
    NSString *accountName = trimAll(self.accountName.text);
    NSString *password = trimAll(self.password.text);
    NSString *encryptionCode = trimAll(self.encryptionCode.text);
    
    if ([accountName length] > 0 && [password length] > 0 && [encryptionCode length] > 0) {
        Password *newPassword = [[Password alloc] init];
        NSString *encryptedPass = [self encryptPassword:password withKey:encryptionCode];
        
        [newPassword setAccountName:accountName];
        [newPassword setPassword:encryptedPass];
        [newPassword setEncryptionCode:encryptionCode];
        
        [self.passwords addObject:newPassword];
        
        //clear inputs
        self.accountName.text = @"";
        self.password.text = @"";
        self.encryptionCode.text = @"";
        
        [self.accountName resignFirstResponder];
        [self.password resignFirstResponder];
        [self.encryptionCode resignFirstResponder];
    }
    else{
        UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"Restriction" message:@"You must fill all fields" delegate:nil cancelButtonTitle:@"OK" otherButtonTitles:nil, nil];
        [alert show];
    }
}

- (IBAction)genRandomPassword:(id)sender {
    NSString *randomPass = [self genRandomString];
    self.password.text = randomPass;
}

-(NSString *)genRandomString{
    static NSString *symbols = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    int length = arc4random_uniform(30);
    
    NSMutableString *randomStr = [[NSMutableString alloc] initWithCapacity:length];
    
    for (int i = 0; i < length; i++) {
        [randomStr appendFormat:@"%C",[symbols characterAtIndex:arc4random() % length]];
    }
    
    return randomStr;
}

-(NSString *)encryptPassword:(NSString *)password withKey:(NSString *)key{
    NSData *plainData = [password dataUsingEncoding:NSUTF8StringEncoding];
    NSData *encryptedData = [plainData AES256encryptWithKey:key];
    
    NSString *encryptedStr = [[NSString alloc] initWithData:encryptedData encoding:NSASCIIStringEncoding];
    
    return encryptedStr;
}



-(void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender{
    PasswordsTableViewController *controller = [segue destinationViewController];
    
    [controller setPasswords:self.passwords];
}

-(void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event{
    [self.view endEditing:TRUE];
}
@end
