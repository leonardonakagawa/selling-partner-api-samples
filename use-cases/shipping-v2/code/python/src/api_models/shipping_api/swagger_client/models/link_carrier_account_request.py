# coding: utf-8

"""
    Amazon Shipping API

    The Amazon Shipping API is designed to support outbound shipping use cases both for orders originating on Amazon-owned marketplaces as well as external channels/marketplaces. With these APIs, you can request shipping rates, create shipments, cancel shipments, and track shipments.  # noqa: E501

    OpenAPI spec version: v2
    Contact: swa-api-core@amazon.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class LinkCarrierAccountRequest(object):
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
        'client_reference_details': 'ClientReferenceDetails',
        'carrier_account_type': 'CarrierAccountType',
        'carrier_account_attributes': 'CarrierAccountAttributes',
        'encrypted_carrier_account_attributes': 'CarrierAccountAttributes'
    }

    attribute_map = {
        'client_reference_details': 'clientReferenceDetails',
        'carrier_account_type': 'carrierAccountType',
        'carrier_account_attributes': 'carrierAccountAttributes',
        'encrypted_carrier_account_attributes': 'encryptedCarrierAccountAttributes'
    }

    def __init__(self, client_reference_details=None, carrier_account_type=None, carrier_account_attributes=None, encrypted_carrier_account_attributes=None):  # noqa: E501
        """LinkCarrierAccountRequest - a model defined in Swagger"""  # noqa: E501
        self._client_reference_details = None
        self._carrier_account_type = None
        self._carrier_account_attributes = None
        self._encrypted_carrier_account_attributes = None
        self.discriminator = None
        if client_reference_details is not None:
            self.client_reference_details = client_reference_details
        self.carrier_account_type = carrier_account_type
        self.carrier_account_attributes = carrier_account_attributes
        if encrypted_carrier_account_attributes is not None:
            self.encrypted_carrier_account_attributes = encrypted_carrier_account_attributes

    @property
    def client_reference_details(self):
        """Gets the client_reference_details of this LinkCarrierAccountRequest.  # noqa: E501


        :return: The client_reference_details of this LinkCarrierAccountRequest.  # noqa: E501
        :rtype: ClientReferenceDetails
        """
        return self._client_reference_details

    @client_reference_details.setter
    def client_reference_details(self, client_reference_details):
        """Sets the client_reference_details of this LinkCarrierAccountRequest.


        :param client_reference_details: The client_reference_details of this LinkCarrierAccountRequest.  # noqa: E501
        :type: ClientReferenceDetails
        """

        self._client_reference_details = client_reference_details

    @property
    def carrier_account_type(self):
        """Gets the carrier_account_type of this LinkCarrierAccountRequest.  # noqa: E501


        :return: The carrier_account_type of this LinkCarrierAccountRequest.  # noqa: E501
        :rtype: CarrierAccountType
        """
        return self._carrier_account_type

    @carrier_account_type.setter
    def carrier_account_type(self, carrier_account_type):
        """Sets the carrier_account_type of this LinkCarrierAccountRequest.


        :param carrier_account_type: The carrier_account_type of this LinkCarrierAccountRequest.  # noqa: E501
        :type: CarrierAccountType
        """
        if carrier_account_type is None:
            raise ValueError("Invalid value for `carrier_account_type`, must not be `None`")  # noqa: E501

        self._carrier_account_type = carrier_account_type

    @property
    def carrier_account_attributes(self):
        """Gets the carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501


        :return: The carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501
        :rtype: CarrierAccountAttributes
        """
        return self._carrier_account_attributes

    @carrier_account_attributes.setter
    def carrier_account_attributes(self, carrier_account_attributes):
        """Sets the carrier_account_attributes of this LinkCarrierAccountRequest.


        :param carrier_account_attributes: The carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501
        :type: CarrierAccountAttributes
        """
        if carrier_account_attributes is None:
            raise ValueError("Invalid value for `carrier_account_attributes`, must not be `None`")  # noqa: E501

        self._carrier_account_attributes = carrier_account_attributes

    @property
    def encrypted_carrier_account_attributes(self):
        """Gets the encrypted_carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501


        :return: The encrypted_carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501
        :rtype: CarrierAccountAttributes
        """
        return self._encrypted_carrier_account_attributes

    @encrypted_carrier_account_attributes.setter
    def encrypted_carrier_account_attributes(self, encrypted_carrier_account_attributes):
        """Sets the encrypted_carrier_account_attributes of this LinkCarrierAccountRequest.


        :param encrypted_carrier_account_attributes: The encrypted_carrier_account_attributes of this LinkCarrierAccountRequest.  # noqa: E501
        :type: CarrierAccountAttributes
        """

        self._encrypted_carrier_account_attributes = encrypted_carrier_account_attributes

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
        if issubclass(LinkCarrierAccountRequest, dict):
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
        if not isinstance(other, LinkCarrierAccountRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
