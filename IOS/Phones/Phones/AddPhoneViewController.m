//
//  AddPhoneViewController.m
//  Phones
//
//  Created by John Doe on 1/29/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import "AddPhoneViewController.h"
#import "AppDelegate.h"
#import "Phone.h"

@interface AddPhoneViewController ()
@property (weak, nonatomic) IBOutlet UITextField *gsmModel;
@property (weak, nonatomic) IBOutlet UITextField *gsmManufacturer;
@property (weak, nonatomic) IBOutlet UITextField *gsmPrice;
@property (weak, nonatomic) IBOutlet UITextField *gsmOwner;

- (IBAction)addGsm:(id)sender;


@end

@implementation AddPhoneViewController

- (void)viewDidLoad {
    [super viewDidLoad];
}

- (IBAction)addGsm:(id)sender {
    NSLog(@"here");
    double priceValue = [self.gsmPrice.text doubleValue];
    Battery *battery = [Battery batteryWithType:LiIon hoursTalk:20 hoursIdle:40];
    Display *display = [Display displayWithSize:20 colorsCount:300];
    Phone *phone = [Phone phoneWithManufacturer:[self.gsmManufacturer text] model:[self.gsmOwner text] price:priceValue owner:[self.gsmModel text] battery:battery display:display];
    AppDelegate *delegate = [UIApplication sharedApplication].delegate;
    [delegate.data addPhone:phone];
    
    [self.navigationController popViewControllerAnimated:YES];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
}

@end
