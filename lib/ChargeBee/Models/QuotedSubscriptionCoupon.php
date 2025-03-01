<?php

namespace ChargeBee\ChargeBee\Models;

use ChargeBee\ChargeBee\Model;

class QuotedSubscriptionCoupon extends Model
{
    protected $allowed = [
        'coupon_id',
        'apply_till',
        'applied_count',
        'coupon_code',
    ];
}
