//
//  FrakyTableViewContronner.m
//  Phones
//
//  Created by John Doe on 1/29/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "FrakyTableViewController.h"
#import "Display.h"
#import "AppDelegate.h"

@implementation FrakyTableViewController: UITableViewController

- (void)insertNewObject:(id)sender {
    if (!self.phones) {
        self.phones = [[NSMutableArray alloc] init];
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
    
    /*AppDelegate *delegate = [UIApplication sharedApplication].delegate;
    self.phones = [delegate.data phones];
    [self.tableView reloadData];*/
}

- (void)viewWillAppear:(BOOL)animated {
    self.clearsSelectionOnViewWillAppear = self.splitViewController.isCollapsed;
    [super viewWillAppear:animated];
    
    AppDelegate *delegate = [UIApplication sharedApplication].delegate;
    self.phones = [delegate.data phones];
    [self.tableView reloadData];
}

- (id) init {
    self = [super init];
    if (self) {
        self.table = [UITableView init];
        self.button = [UIButton init];
        self.label = [UILabel init];
    }
    
    return self;
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
        AppDelegate* delegate = [UIApplication sharedApplication].delegate;
        [delegate.data deletePhone:[self.phones objectAtIndex:indexPath.row]];
        self.phones = [delegate.data phones];
        [self.tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    }
}

- (id) initWithCoder: (NSCoder *) coder {
    return self = [super initWithCoder: coder];
}

@end