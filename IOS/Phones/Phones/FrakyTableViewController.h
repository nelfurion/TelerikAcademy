//
//  FrakyTableViewController.h
//  Phones
//
//  Created by John Doe on 1/29/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#ifndef FrakyTableViewController_h
#define FrakyTableViewController_h
#include <CoreGraphics/CGGeometry.h>
#import <UIKit/UIKit.h>
#import "DetailViewController.h"

@interface FrakyTableViewController: UITableViewController

@property (strong, nonatomic) DetailViewController *detailViewController;
@property (strong) NSMutableArray *phones;
@property (nonatomic) UITableView *table;
@property (nonatomic) UIButton *button;
@property (nonatomic) UILabel *label;

- (id) init;

- (id)initWithFrame:(CGRect)frame;

- (id)initWithCoder:(NSCoder *)aDecoder;

@end

#endif /* FrakyTableViewController_h */
