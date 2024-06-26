# coding: utf-8

"""
    Selling Partner API for Data Kiosk

    The Selling Partner API for Data Kiosk lets you submit GraphQL queries from a variety of schemas to help selling partners manage their businesses.  # noqa: E501

    OpenAPI spec version: 2023-11-15
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class GetQueriesResponse(object):
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
        'queries': 'QueryList',
        'pagination': 'GetQueriesResponsePagination'
    }

    attribute_map = {
        'queries': 'queries',
        'pagination': 'pagination'
    }

    def __init__(self, queries=None, pagination=None):  # noqa: E501
        """GetQueriesResponse - a model defined in Swagger"""  # noqa: E501
        self._queries = None
        self._pagination = None
        self.discriminator = None
        self.queries = queries
        if pagination is not None:
            self.pagination = pagination

    @property
    def queries(self):
        """Gets the queries of this GetQueriesResponse.  # noqa: E501


        :return: The queries of this GetQueriesResponse.  # noqa: E501
        :rtype: QueryList
        """
        return self._queries

    @queries.setter
    def queries(self, queries):
        """Sets the queries of this GetQueriesResponse.


        :param queries: The queries of this GetQueriesResponse.  # noqa: E501
        :type: QueryList
        """
        if queries is None:
            raise ValueError("Invalid value for `queries`, must not be `None`")  # noqa: E501

        self._queries = queries

    @property
    def pagination(self):
        """Gets the pagination of this GetQueriesResponse.  # noqa: E501


        :return: The pagination of this GetQueriesResponse.  # noqa: E501
        :rtype: GetQueriesResponsePagination
        """
        return self._pagination

    @pagination.setter
    def pagination(self, pagination):
        """Sets the pagination of this GetQueriesResponse.


        :param pagination: The pagination of this GetQueriesResponse.  # noqa: E501
        :type: GetQueriesResponsePagination
        """

        self._pagination = pagination

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
        if issubclass(GetQueriesResponse, dict):
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
        if not isinstance(other, GetQueriesResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
