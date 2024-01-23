# coding: utf-8

"""
    Selling Partner API for Merchant Fulfillment

    The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.  # noqa: E501

    OpenAPI spec version: v0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from src.api_models.mfn_api.swagger_client.configuration import Configuration


class GetEligibleShipmentServicesResult(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'shipping_service_list': 'ShippingServiceList',
        'rejected_shipping_service_list': 'RejectedShippingServiceList',
        'temporarily_unavailable_carrier_list': 'TemporarilyUnavailableCarrierList',
        'terms_and_conditions_not_accepted_carrier_list': 'TermsAndConditionsNotAcceptedCarrierList'
    }

    attribute_map = {
        'shipping_service_list': 'ShippingServiceList',
        'rejected_shipping_service_list': 'RejectedShippingServiceList',
        'temporarily_unavailable_carrier_list': 'TemporarilyUnavailableCarrierList',
        'terms_and_conditions_not_accepted_carrier_list': 'TermsAndConditionsNotAcceptedCarrierList'
    }

    def __init__(self, shipping_service_list=None, rejected_shipping_service_list=None, temporarily_unavailable_carrier_list=None, terms_and_conditions_not_accepted_carrier_list=None, _configuration=None):  # noqa: E501
        """GetEligibleShipmentServicesResult - a model defined in Swagger"""  # noqa: E501
        if _configuration is None:
            _configuration = Configuration()
        self._configuration = _configuration

        self._shipping_service_list = None
        self._rejected_shipping_service_list = None
        self._temporarily_unavailable_carrier_list = None
        self._terms_and_conditions_not_accepted_carrier_list = None
        self.discriminator = None

        self.shipping_service_list = shipping_service_list
        if rejected_shipping_service_list is not None:
            self.rejected_shipping_service_list = rejected_shipping_service_list
        if temporarily_unavailable_carrier_list is not None:
            self.temporarily_unavailable_carrier_list = temporarily_unavailable_carrier_list
        if terms_and_conditions_not_accepted_carrier_list is not None:
            self.terms_and_conditions_not_accepted_carrier_list = terms_and_conditions_not_accepted_carrier_list

    @property
    def shipping_service_list(self):
        """Gets the shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501

        A list of shipping services offers.  # noqa: E501

        :return: The shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :rtype: ShippingServiceList
        """
        return self._shipping_service_list

    @shipping_service_list.setter
    def shipping_service_list(self, shipping_service_list):
        """Sets the shipping_service_list of this GetEligibleShipmentServicesResult.

        A list of shipping services offers.  # noqa: E501

        :param shipping_service_list: The shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :type: ShippingServiceList
        """
        if self._configuration.client_side_validation and shipping_service_list is None:
            raise ValueError("Invalid value for `shipping_service_list`, must not be `None`")  # noqa: E501

        self._shipping_service_list = shipping_service_list

    @property
    def rejected_shipping_service_list(self):
        """Gets the rejected_shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501


        :return: The rejected_shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :rtype: RejectedShippingServiceList
        """
        return self._rejected_shipping_service_list

    @rejected_shipping_service_list.setter
    def rejected_shipping_service_list(self, rejected_shipping_service_list):
        """Sets the rejected_shipping_service_list of this GetEligibleShipmentServicesResult.


        :param rejected_shipping_service_list: The rejected_shipping_service_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :type: RejectedShippingServiceList
        """

        self._rejected_shipping_service_list = rejected_shipping_service_list

    @property
    def temporarily_unavailable_carrier_list(self):
        """Gets the temporarily_unavailable_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501


        :return: The temporarily_unavailable_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :rtype: TemporarilyUnavailableCarrierList
        """
        return self._temporarily_unavailable_carrier_list

    @temporarily_unavailable_carrier_list.setter
    def temporarily_unavailable_carrier_list(self, temporarily_unavailable_carrier_list):
        """Sets the temporarily_unavailable_carrier_list of this GetEligibleShipmentServicesResult.


        :param temporarily_unavailable_carrier_list: The temporarily_unavailable_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :type: TemporarilyUnavailableCarrierList
        """

        self._temporarily_unavailable_carrier_list = temporarily_unavailable_carrier_list

    @property
    def terms_and_conditions_not_accepted_carrier_list(self):
        """Gets the terms_and_conditions_not_accepted_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501


        :return: The terms_and_conditions_not_accepted_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :rtype: TermsAndConditionsNotAcceptedCarrierList
        """
        return self._terms_and_conditions_not_accepted_carrier_list

    @terms_and_conditions_not_accepted_carrier_list.setter
    def terms_and_conditions_not_accepted_carrier_list(self, terms_and_conditions_not_accepted_carrier_list):
        """Sets the terms_and_conditions_not_accepted_carrier_list of this GetEligibleShipmentServicesResult.


        :param terms_and_conditions_not_accepted_carrier_list: The terms_and_conditions_not_accepted_carrier_list of this GetEligibleShipmentServicesResult.  # noqa: E501
        :type: TermsAndConditionsNotAcceptedCarrierList
        """

        self._terms_and_conditions_not_accepted_carrier_list = terms_and_conditions_not_accepted_carrier_list

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(GetEligibleShipmentServicesResult, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, GetEligibleShipmentServicesResult):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, GetEligibleShipmentServicesResult):
            return True

        return self.to_dict() != other.to_dict()