//
//  DetailViewController.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import "DetailViewController.h"
#import "Phone.h"

@interface DetailViewController ()

@end

@implementation DetailViewController

#pragma mark - Managing the detail item

- (void)setDetailItem:(id)newDetailItem {
    if (_detailItem != newDetailItem) {
        _detailItem = newDetailItem;
            
        // Update the view.
        [self configureView];
    }
}

- (void)configureView {
    // Update the user interface for the detail item.
    if (self.detailItem) {
        self.phoneModel.text = self.detailItem.model;
        self.phoneOwner.text = self.detailItem.owner;
        NSString *priceAsText = [NSString stringWithFormat:@"%f", self.detailItem.price];
        self.phonePrice.text = priceAsText;
        self.phoneManufacturer.text = self.detailItem.manufacturer;
    }
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    [self configureView];
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
