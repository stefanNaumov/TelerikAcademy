//
//  PasswordsTableViewController.m
//  PasswordsManager
//
//  Created by admin on 10/29/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "PasswordsTableViewController.h"

@implementation PasswordsTableViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    // Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section{
    return [self.passwords count];
}

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath{
    
    NSString *cellIdentifier = @"Cell";
    
    UITableViewCell *cell = [self.tableView dequeueReusableCellWithIdentifier:cellIdentifier forIndexPath:indexPath];
    Password *currPassword = [self.passwords objectAtIndex:indexPath.row];
    
    NSString *passwordCell = [[NSString alloc] initWithFormat:@"Account:%@ password:%@",[currPassword accountName], [currPassword password]];
    
    cell.textLabel.text = passwordCell;
    
    return cell;
}

-(void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender{
    
    PasswordDecryptViewController *controller = [segue destinationViewController];
    
    NSIndexPath *path = [self.tableView indexPathForSelectedRow];
    Password *currPass = [self.passwords objectAtIndex:path.row];
    
    [controller setPassword:currPass];
}

@end
