<?php
namespace ChargeBee\ChargeBee\Models;

use ChargeBee\ChargeBee\Model;

class Hierarchy extends Model
{
    protected $allowed = [
        'customerId',
        'parentId',
        'paymentOwnerId',
        'invoiceOwnerId',
        'childrenIds',
    ];

    # OPERATIONS
    #-----------
}
