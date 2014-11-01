//
//  ListDetailsViewController.m
//  NotesList
//
//  Created by admin on 11/1/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "ListDetailsViewController.h"

@interface ListDetailsViewController ()

@end

@implementation ListDetailsViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    NSLog(@"%@",[self.notesList title]);
    
    self.titleOutputLabel.text = [self.notesList title];
    self.categoryOutputLabel.text = [self.notesList category];
    // Do any additional setup after loading the view.
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

-(UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath{
    
    static NSString *identifier = @"noteCell";
    UITableViewCell *cell = [self.notesTableView dequeueReusableCellWithIdentifier:identifier forIndexPath:indexPath];
    
    Note *currNote = [[self.notesList notes] objectAtIndex:indexPath.row];
    cell.textLabel.text = [currNote title];
    
    return cell;
    
}

-(NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section{
    return [[self.notesList notes] count];
}


/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
