//
//  MasterViewController.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import "MasterViewController.h"
#import "DetailViewController.h"
#import "Phone.h"
#import "Battery.h"
#import "Display.h"
#import "Battery_Type.h"
#import "AppDelegate.h"
#import "AddPhoneViewController.h"

@interface MasterViewController ()

@property NSMutableArray *objects;
@end

@implementation MasterViewController

- (void)insertNewObject:(id)sender {
    if (!self.phones) {
        AppDelegate *delegate = [UIApplication sharedApplication].delegate;
        self.phones = [delegate.data phones];
    }
    
    Display *simpleDisplay = [[Display alloc] initWithSize:22 colorsCount:16000];
    Battery *simpleBattery = [Battery batteryWithType:LiIon hoursTalk:20 hoursIdle:40];
    Phone *newPhone = [[Phone alloc] initWithManufacturer:@"Apple" model:@"IPhone 6s" price:3000 owner:@"Bill Gates" battery:simpleBattery display:simpleDisplay];
    [self.phones insertObject:newPhone atIndex:0];
    NSIndexPath *indexPath = [NSIndexPath indexPathForRow:0 inSection:0];
    [self.tableView insertRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationAutomatic];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    self.navigationItem.leftBarButtonItem = self.editButtonItem;

    UIBarButtonItem *addButton = [[UIBarButtonItem alloc] initWithBarButtonSystemItem:UIBarButtonSystemItemAdd target:self action:@selector(insertNewObject:)];
    self.navigationItem.rightBarButtonItem = addButton;
    
    self.title = @"Best phone app";
}

- (void)viewWillAppear:(BOOL)animated {
    self.clearsSelectionOnViewWillAppear = self.splitViewController.isCollapsed;
    [super viewWillAppear:animated];
    
    AppDelegate *delegate = [UIApplication sharedApplication].delegate;
    self.phones = [delegate.data phones];
    [self.tableView reloadData];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
}

- (void) prepareForSegue: (UIStoryboardSegue *) segue sender: (id) sender
{
    //if segue is not created on the button
    /*if ([sender isKindOfClass:[UIButton class]]) {
        ...
        [self performSegueWithIdentifier:@"AddGSMSegue" sender:self];
    }*/
    if ([sender isKindOfClass: [UITableViewCell class]]) {
        DetailViewController *detailController = segue.destinationViewController;
        Phone *selectedPhone = [self.phones objectAtIndex:self.tableView.indexPathForSelectedRow.row];
        detailController.detailItem = selectedPhone;
    }
    
    return;
}

-(void) showAdd {
    NSString *storyBoardId = @"addPhoneScene";
    
    AddPhoneViewController *addPhoneVC =
    [self.storyboard instantiateViewControllerWithIdentifier:storyBoardId];
    [self.navigationController pushViewController:addPhoneVC animated:YES];
}

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    return self.phones.count;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"Cell" forIndexPath:indexPath];
    
    Phone *phone = self.phones [indexPath.row];
    cell.textLabel.text = phone.model;
    cell.imageView.image = NULL;
    return cell;
}

- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath {
    return YES;
}

- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath {
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        [self.phones removeObjectAtIndex:indexPath.row];
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    }
}

@end
