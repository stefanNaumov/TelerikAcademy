//
//  MainTableViewController.m
//  CustomTableViewCell
//
//  Created by admin on 11/1/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "MainTableViewController.h"

@interface MainTableViewController ()

@end

static NSInteger rowsCount = 10;
static NSString *identifier = @"CustomCell";

@implementation MainTableViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    UINib *nib = [UINib nibWithNibName:@"CustomTableViewCell" bundle:nil];
    [self.tableView registerNib:nib forCellReuseIdentifier:identifier];
    
    self.images = [[NSMutableArray alloc] init];
    [self initImages];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

#pragma mark - Table view data source

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {

    return [self.images count];
}


- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    
    CustomUITableViewCell *customCell = [self.tableView dequeueReusableCellWithIdentifier:identifier forIndexPath:indexPath];
    
    Image *currImage = [self.images objectAtIndex:indexPath.row];
    UIImage *uiImage = [UIImage imageNamed:currImage.fileName];
    
    customCell.titleLabel.text = currImage.title;
    [customCell.imageView setImage:uiImage];
   
    return customCell;
}

-(void) initImages{
    
    Image *img = [[Image alloc] init];
    [img setTitle:@"Ferrari Enzo"];
    [img setFileName:@"ferrari-enzo"];
    
    [self.images addObject:img];
    
    img = [[Image alloc] init];
    [img setTitle:@"Lamborghini Diablo"];
    [img setFileName:@"lamborghini-diablo"];

    
    [self.images addObject:img];

    
    img = [[Image alloc] init];
    [img setTitle:@"Pagani Zonda"];
    [img setFileName:@"pagani-zonda"];
    
    [self.images addObject:img];
    
    img = [[Image alloc] init];
    [img setTitle:@"Rolls-Royce Wraith"];
    [img setFileName:@"rollsroyce-wraith"];
    
    [self.images addObject:img];
}

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath {
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        // Delete the row from the data source
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    } else if (editingStyle == UITableViewCellEditingStyleInsert) {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath {
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
