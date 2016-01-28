//
//  DetailViewController.h
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <UIKit/UIKit.h>
#import "Phone.h"

@interface DetailViewController : UIViewController

@property (strong, nonatomic) Phone* detailItem;
@property (weak, nonatomic) IBOutlet UILabel *detailDescriptionLabel;
@property (weak, nonatomic) IBOutlet UILabel *phoneModel;
@property (weak, nonatomic) IBOutlet UILabel *phonePrice;
@property (weak, nonatomic) IBOutlet UILabel *phoneOwner;
@property (weak, nonatomic) IBOutlet UILabel *phoneManufacturer;

@end

