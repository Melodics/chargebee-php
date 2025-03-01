<?php

namespace ChargeBee\ChargeBee\Models;

use ChargeBee\ChargeBee\Model;

class SubscriptionAddon extends Model
{
    protected $allowed = [
        'id',
        'quantity',
        'unit_price',
        'amount',
        'trial_end',
        'remaining_billing_cycles',
        'quantity_in_decimal',
        'unit_price_in_decimal',
        'amount_in_decimal',
    ];
}
