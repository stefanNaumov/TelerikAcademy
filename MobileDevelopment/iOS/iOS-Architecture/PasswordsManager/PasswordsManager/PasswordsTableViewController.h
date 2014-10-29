//
//  PasswordsTableViewController.h
//  PasswordsManager
//
//  Created by admin on 10/29/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Password.h"
#import "PasswordDecryptViewController.h"

@interface PasswordsTableViewController : UITableViewController<UITableViewDelegate,UITableViewDataSource>{
    
}

@property (nonatomic) NSMutableArray *passwords;

@end
